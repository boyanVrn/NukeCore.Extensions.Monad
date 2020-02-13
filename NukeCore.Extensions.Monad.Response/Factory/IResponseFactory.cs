﻿using NukeCore.Extensions.Monad.Response.Models;
using NukeCore.Extensions.Monad.Response.Models.Base.Interfaces;

namespace NukeCore.Extensions.Monad.Response.Factory
{
    public interface IResponseFactory
    {
        ResponseBase<TData> CreateSuccess<TData>(TData data);
        ResponseBase<TData> CreateFault<TData>(IFail error);
        ResponseBase<TData> CreateInstance<TData>(TData data, IFail error);
    }
}