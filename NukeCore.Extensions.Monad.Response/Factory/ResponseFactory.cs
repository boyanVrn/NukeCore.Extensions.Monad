using NukeCore.Extensions.Monad.Response.Models;
using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Factory
{
    public class ResponseFactory : IResponseFactory
    {
        public IResponse<TData> CreateSuccess<TData>(TData data) => new ResponseBase<TData>(data);
        public IResponse<TData> CreateFault<TData>(IFail error) => new ResponseBase<TData>(error);

        public ResponseBase CreateSuccess() => new ResponseBase();
        public ResponseBase CreateFault(IFail error) => new ResponseBase(error);

        public IResponse<TData> CreateInstance<TData>(TData data, IFail error) => new ResponseBase<TData>(data, error);
    }
}
