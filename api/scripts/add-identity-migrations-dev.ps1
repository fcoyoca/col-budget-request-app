param(
     [Parameter(Mandatory=$true)]
     [ValidateNotNullOrEmpty()]
     [string]$commitMessage  
 )
 
$rootDirectory = git rev-parse --show-toplevel
$hostDirectory = $rootDirectory + '/api/server'
Set-Location -Path $hostDirectory
Write-Host "Host Directory is $hostDirectory `n"

<# $commitMessage = 'UpdateREADME' #>
Write-Host "Commit Message is $commitMessage `n"

<# Declaring Connection String #>
Write-Host "Setting Connection Strings..."
$mssqlConnectionString = "Server=localhost;Database=BudgetingDb;User Id=sa;Password=P@ssw0rd_1;TrustServerCertificate=True;"
Write-Host 'Connection String is ' + $mssqlConnectionString

<# Defining JSON Paths #>
Write-Host "Defining JSON Paths... `n"
$databaseJsonPath = $hostDirectory +'/appsettings.Development.json'
Write-Host 'Database Path is ' + $databaseJsonPath

<# Get Current Config #>
Write-Host "Getting Current Config...`n"
$databaseFileContent = Get-Content $databaseJsonPath -raw
Write-Host 'Database File Content Path is ' + $databaseFileContent

Write-Host "Creating Config Objects...`n"
$databaseJsonContent = Get-Content $databaseJsonPath -raw | ConvertFrom-Json
Write-Host "**************************`n"

<# MSSQL #>
Write-Host "Updating Configurations for MSSQL Provider..."
$databaseJsonContent.DatabaseOptions.Provider = "mssql"
$databaseJsonContent.DatabaseOptions.ConnectionString = $mssqlConnectionString
$databaseJsonContent | ConvertTo-Json | set-content $databaseJsonPath

Write-Host "Adding Migrations for MSSQL Provider..."
dotnet ef migrations add $commitMessage --project .././Migrations/MSSQL/ --context IdentityDbContext -o Identity
Write-Host "Adding Migrations for MSSQL Provider...Done`n"
Write-Host "**************************`n"


<# Reset Configurations - Switch Back to Original Configurations #>
Write-Host "Resetting Configurations to Orginal...`n"
$databaseFileContent | set-content -NoNewline -Force $databaseJsonPath
$hangfireFileContent | set-content -NoNewline -Force $hangfireJsonPath
Write-Host "**************************`n"

$currentDirectory = git rev-parse --show-toplevel
Set-Location -Path $rootDirectory
Write-Host -NoNewLine 'Migrations Added. Press any key to continue...';
$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');
