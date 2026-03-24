namespace Postech.Shared.Contracts.Events;

public enum PaymentProcessedStatus
{
    Pending,
    Completed,
    Failed,
    Cancelled
}

public class PaymentProcessedEvent
{
    public Guid OrderId { get; set; }
    public Guid UserId { get; set; }
    public Guid GameId { get; set; }
    public PaymentProcessedStatus Status { get; set; }
}
