using NukeCore.Extensions.Monad.Response.Models;
using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Factory
{
    public interface IResponseFactory
    {
        IResponse<TData> CreateSuccess<TData>(TData data);
        IResponse<TData> CreateFault<TData>(IFail error);

        ResponseBase CreateSuccess();
        ResponseBase CreateFault(IFail error);

        IResponse<TData> CreateInstance<TData>(TData data, IFail error);
    }
}
