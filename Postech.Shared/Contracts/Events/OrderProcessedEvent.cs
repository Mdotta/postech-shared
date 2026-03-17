namespace Postech.Shared.Contracts.Events;

public class OrderProcessedEvent
{
    public Guid OrderId { get; init; }
    public bool IsSuccessful { get; init; }
    public string? FailureReason { get; init; }
}