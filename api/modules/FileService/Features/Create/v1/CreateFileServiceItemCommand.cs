using System.ComponentModel;
using System.Net;
using FSH.Framework.Core.Storage.File.Features;
using Google.Protobuf.Compiler;
using MediatR;

namespace budget_request_app.WebApi.FileService.Features.Create.v1;
public record CreateFileServiceItemCommand(
    FileUploadCommand? File
    ) :
    IRequest<CreateFileServiceItemResponse>;
