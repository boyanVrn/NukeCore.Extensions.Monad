﻿using System;
using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Models.Base.Resolvers
{
    public class ApiError<T> : IError<T>, ISuccess
    {
        public T Error { get; set; }

        public bool IsSuccess { get; }

        public ApiError()
        {
            IsSuccess = false;
        }

        public ApiError(object error)
        {
            if(error == null)
                throw new ArgumentNullException();

            Error = (T) error;
            IsSuccess = false;
        }
    }
}
