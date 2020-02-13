using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Models.Base.Resolvers
{
    public class ApiOk<T> : IData<T>, ISuccess
    {
        public T Data { get; }

        public bool IsSuccess { get; }

        public ApiOk(object data)
        {
            Data = (T) (data ?? new object());
            IsSuccess = true;
        }
    }
}
