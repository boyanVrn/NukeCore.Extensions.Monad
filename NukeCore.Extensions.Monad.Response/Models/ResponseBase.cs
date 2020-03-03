using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Models
{

    public class ResponseBase : IResponse
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

        public object Data { get; }

        public bool IsSuccess { get; private set; }
        protected virtual bool IsOkError(IFail error) => error == null;

        public ResponseBase(IFail error)
        {
            IsSuccess = false;
            _error = error;
        }

        public ResponseBase()
        {
            IsSuccess = true;
            Data = new { };
        }
    }

    public class ResponseBase<TData> : ResponseBase, IResponse<TData>
    {
        public new TData Data { get; }

        public ResponseBase(IFail error) : base(error) { }

        public ResponseBase(TData data)
        {
            Data = data;
        }

        public ResponseBase(TData data, IFail error) : base(error)
        {
            Data = data;
        }

    }


}
