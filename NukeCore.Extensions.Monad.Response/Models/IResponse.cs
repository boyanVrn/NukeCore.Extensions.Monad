using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Models
{
    public interface IResponse : IError<IFail>, ISuccess { }

    public interface IResponse<out TData> : IResponse, IData<TData> { }
}