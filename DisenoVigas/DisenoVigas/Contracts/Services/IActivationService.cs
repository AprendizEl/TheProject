namespace DisenoVigas.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
