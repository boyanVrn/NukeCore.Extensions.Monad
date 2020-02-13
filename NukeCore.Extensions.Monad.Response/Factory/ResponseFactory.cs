using NukeCore.Extensions.Monad.Response.Models;
using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Factory
{
    public class ResponseFactory : IResponseFactory
    {
        public ResponseBase<TData> CreateSuccess<TData>(TData data) => new ResponseBase<TData>(data);
        public ResponseBase<TData> CreateFault<TData>(IFail error) => new ResponseBase<TData>(error);
        public ResponseBase<TData> CreateInstance<TData>(TData data, IFail error) => new ResponseBase<TData>(data, error);
    }
}
