namespace ECAP.Application.Wrappers;

public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public T? Data { get; set; }
    public string? ErrorCode { get; set; }

    public static ApiResponse<T> Ok(T data, string message = "Success") 
        => new() { Success = true, Data = data, Message = message };

    public static ApiResponse<T> Fail(string errorCode, string message) 
        => new() { Success = false, ErrorCode = errorCode, Message = message };
}