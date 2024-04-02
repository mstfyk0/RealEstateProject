using Domain.Common.Enums;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Domain.Common.Interface;
using Domain.Common.Wrapper;
using Application.Exceptions;
using System.Threading.RateLimiting;

namespace Persistence.Filter
{
    public sealed class ApiExceptionFilterAttribute : ExceptionFilterAttribute, IApiExceptionFilter
    {
        public ApiExceptionFilterAttribute()
        {
        }

        public override Task OnExceptionAsync(ExceptionContext context)
        {
            Response<object> response = new Response<object>()
            {
                data = default
            };
            Exception exception = context.Exception;



            switch (exception)
            {
                case ApiException e:
                    // custom application error
                    response.apiResultType = ApiResultEnum.Warning;
                    response.statusCode = (int)HttpStatusCode.BadRequest;
                    response.message = e.Message;
                    break;
                case KeyNotFoundException e:
                    response.statusCode = (int)HttpStatusCode.NotFound;
                    response.apiResultType = ApiResultEnum.Error;
                    break;
                default:
                    response.statusCode = (int)HttpStatusCode.InternalServerError;
                    response.apiResultType = ApiResultEnum.Error;
                    response.message = "The recording(s) you are trying to view encountered an issue. Please try again later.";
                    break;
            }

            context.Result = new JsonResult(response)
            {
                StatusCode = response.statusCode,
            };

            context.ExceptionHandled = true;

            return Task.CompletedTask;
        }
    }
}
