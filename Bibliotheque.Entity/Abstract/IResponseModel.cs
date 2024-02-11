namespace Bibliotheque.Entity;

public interface IResponseModel
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public int StatusCode { get; set; }

}

public interface IResponseDataModel<T> : IResponseModel
{
    public T Data { get; set; }
}