namespace NukeCore.Extensions.Monad.Response.Models.Base.Interfaces
{
    public interface IData<out T>
    {
        T Data { get;}
    }
}
