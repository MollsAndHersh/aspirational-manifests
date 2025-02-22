namespace Aspirate.Shared.Commands;

public interface ICommandOptionsHandler<in TOptions>
{
    AspirateState CurrentState { get; set; }

    Task<int> HandleAsync(TOptions options);
}
