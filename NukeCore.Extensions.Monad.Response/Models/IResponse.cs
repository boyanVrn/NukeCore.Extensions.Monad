using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Models
{
    public interface IResponse<out TData> : IData<TData>, IError<IFail>, ISuccess { }
}