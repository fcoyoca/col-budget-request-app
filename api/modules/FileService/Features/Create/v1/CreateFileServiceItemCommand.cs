using System.ComponentModel;
using System.Net;
using FSH.Framework.Core.Storage.File.Features;
using Google.Protobuf.Compiler;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace budget_request_app.WebApi.FileService.Features.Create.v1;
public record CreateFileServiceItemCommand(
    HttpRequest HttpRequest
    ) :
    IRequest<CreateFileServiceItemResponse>;

