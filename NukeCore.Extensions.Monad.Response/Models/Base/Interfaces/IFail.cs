namespace NukeCore.Extensions.Monad.Response.Models.Base.Interfaces
{
    public interface IFail
    {
        string Code { get; }

        string Description { get; }
    }
}
