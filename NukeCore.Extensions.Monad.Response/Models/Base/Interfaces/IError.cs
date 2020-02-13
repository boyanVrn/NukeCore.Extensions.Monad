namespace NukeCore.Extensions.Monad.Response.Models.Base.Interfaces
{
    public interface IError<out T>
    {
        T Error { get; }
    }
}