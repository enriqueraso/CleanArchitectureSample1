namespace CleanArchitectureSample1.UseCases
{
    public interface IAddRequestResult
    {
        bool Result { get; }
        string Message { get; }
    }
}