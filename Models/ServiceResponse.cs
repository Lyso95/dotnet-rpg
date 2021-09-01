namespace dotnet_rpg.Models
{
    public class ServiceResponse<T> // Data Type <T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null; //Character was addet... Error...
    }
}