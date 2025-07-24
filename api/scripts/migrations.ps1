# Get the root Git directory
try {
    $rootDirectory = git rev-parse --show-toplevel
} catch {
    Write-Error "This script must be run from within a Git repository."
    exit 1
}

# Navigate to the host directory
$hostDirectory = Join-Path $rootDirectory "api/server"
Set-Location -Path $hostDirectory

# List available appsettings*.json files dynamically
$appsettingsFiles = Get-ChildItem -Path $hostDirectory -Filter "appsettings*.json" | Select-Object -ExpandProperty Name

if ($appsettingsFiles.Count -eq 0) {
    Write-Error "No appsettings*.json files found in: $hostDirectory"
    exit 1
}

# Show options dynamically
Write-Host "Select environment configuration:`n"
for ($i = 0; $i -lt $appsettingsFiles.Count; $i++) {
    $displayName = if ($appsettingsFiles[$i] -eq "appsettings.json") { "Production" } else { $appsettingsFiles[$i] -replace "appsettings\.|\.json", "" }
    Write-Host "$($i + 1). $displayName ($($appsettingsFiles[$i]))"
}

# Get user selection
$selection = Read-Host "`nEnter your choice (1-$($appsettingsFiles.Count))"
if (-not ($selection -match '^\d+$') -or $selection -lt 1 -or $selection -gt $appsettingsFiles.Count) {
    Write-Error "Invalid selection."
    exit 1
}

$configFileName = $appsettingsFiles[$selection - 1]
$configPath = Join-Path $hostDirectory $configFileName

# Load and display selected config
$originalConfigContent = Get-Content $configPath -Raw
$configJson = $originalConfigContent | ConvertFrom-Json

Write-Host "`nUsing configuration: $configFileName"
Write-Host "Database Provider : $($configJson.DatabaseOptions.Provider)"
Write-Host "Connection String : $($configJson.DatabaseOptions.ConnectionString)`n"

$confirmation = Read-Host "Proceed with this configuration? (Y/N)"
if ($confirmation -notin @('Y', 'y')) {
    Write-Host "Operation cancelled."
    exit 0
}

# Prompt once for DB context
$contextName = Read-Host "Enter the database context name (e.g., ApplicationDbContext or HealthCareDbContext)"

function Show-Menu {
    Write-Host "`nChoose an operation:"
    Write-Host "1. Add new migration"
    Write-Host "2. Update database"
    Write-Host "3. Remove last migration"
    Write-Host "4. Exit"
}

function Add-Migration {
    $migrationName = Read-Host "Enter migration name"
    $outputDirectory = Read-Host "Enter output directory (Migrations/MSSQL/[e.g.,  Catalog or HealthCare])"

    Write-Host "`nAdding migration..."
    dotnet ef migrations add $migrationName `
        --project ../migrations/MSSQL/MSSQL.csproj `
        --startup-project ../server/Server.csproj `
        --context $contextName `
        --output-dir $outputDirectory

    if ($LASTEXITCODE -eq 0) {
        Write-Host "Migration '$migrationName' created successfully."
    } else {
        Write-Error "Migration creation failed."
    }
}

function Update-Database {
    Write-Host "`nUpdating database..."
    dotnet ef database update `
        --project ../migrations/MSSQL/MSSQL.csproj `
        --startup-project ../server/Server.csproj `
        --context $contextName

    if ($LASTEXITCODE -eq 0) {
        Write-Host "Database updated successfully."
    } else {
        Write-Error "Database update failed."
    }
}

function Remove-Migration {
    Write-Host "`nRemoving last migration..."
    dotnet ef migrations remove `
        --project ../migrations/MSSQL/MSSQL.csproj `
        --startup-project ../server/Server.csproj `
        --context $contextName

    if ($LASTEXITCODE -eq 0) {
        Write-Host "Last migration removed successfully."
    } else {
        Write-Error "Failed to remove migration."
    }
}

# Main menu loop
do {
    Show-Menu
    $choice = Read-Host "Enter choice (1-4)"

    switch ($choice) {
        '1' { Add-Migration }
        '2' { Update-Database }
        '3' { Remove-Migration }
        '4' {
            Write-Host "`nExiting and restoring original config..."
            break
        }
        default { Write-Warning "Invalid choice. Please select 1, 2, 3, or 4." }
    }
} while ($true)

# Restore original config
$originalConfigContent | Set-Content -NoNewline -Force $configPath
Set-Location -Path $rootDirectory
Write-Host "Configuration restored."
Write-Host "`nAll done. Press Enter to exit."
[System.Console]::ReadLine() | Out-Null