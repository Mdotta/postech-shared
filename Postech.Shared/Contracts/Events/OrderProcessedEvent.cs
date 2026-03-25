namespace Postech.Shared.Contracts.Events;

public class OrderProcessedEvent
{
    public Guid OrderId { get; init; }
    public Guid UserId { get; init; }
    public Guid GameId { get; init; }
    public bool IsSuccessful { get; init; }
    public string? FailureReason { get; init; }
}