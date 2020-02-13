using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Models
{

    public class ResponseBase<TData> : IResponse<TData>
    {
        private IFail _error;

        public IFail Error
        {
            get => _error;
            private set
            {
                IsSuccess = IsOkError(value);
                _error = value;
            }
        }

        public TData Data { get; }

        public bool IsSuccess { get; private set; }

        public ResponseBase(IFail error)
        {
            IsSuccess = false;
            _error = error;
        }
        public ResponseBase(TData data)
        {
            Data = data;
            IsSuccess = true;
        }
        public ResponseBase(TData data, IFail error)
        {
            Data = data;
            Error = error;
        }

        protected virtual bool IsOkError(IFail error) => error == null;
    }
}
