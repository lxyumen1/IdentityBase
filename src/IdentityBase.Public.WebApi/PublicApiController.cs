
namespace IdentityBase.Public.WebApi
{
    using System.Reflection;
    using Microsoft.AspNetCore.Mvc;
    using ServiceBase.Mvc;

    [TypeFilter(typeof(ExceptionFilter))]
    [TypeFilter(typeof(ModelStateFilter))]
    [TypeFilter(typeof(BadRequestFilter))]
    public abstract class PublicApiController : ControllerBase
    {
    }
}
