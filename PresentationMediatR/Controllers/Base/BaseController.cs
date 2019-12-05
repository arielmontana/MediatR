using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationMediatR.Controllers.Base
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private readonly IMediator _mediator;
        protected IMediator Mediator => _mediator ?? (dynamic)HttpContext.RequestServices.GetService(typeof(IMediator));
    }
}