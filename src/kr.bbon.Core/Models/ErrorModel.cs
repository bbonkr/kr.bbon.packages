namespace kr.bbon.Core.Models;

public class ErrorModel
{
    public ErrorModel(string Message, string? Code = null, string? Reference = null, IEnumerable<ErrorModel>? InnerErrors = null)
    {
        ArgumentNullException.ThrowIfNull(Message);
        this.Message = Message;
        this.Code = Code;
        this.Reference = Reference;
        this.InnerErrors = InnerErrors ?? Enumerable.Empty<ErrorModel>();
    }

    public string Message { get; init; }

    public string? Code { get; init; }

    public string? Reference { get; init; }

    public IEnumerable<ErrorModel> InnerErrors { get; init; } = [];
}

