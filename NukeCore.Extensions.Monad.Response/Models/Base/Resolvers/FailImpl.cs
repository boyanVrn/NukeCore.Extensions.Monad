using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Models.Base.Resolvers
{
    public class FailImpl : IFail
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
