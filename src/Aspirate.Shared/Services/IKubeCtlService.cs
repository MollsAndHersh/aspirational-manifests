namespace Aspirate.Shared.Services;

public interface IKubeCtlService
{
    Task<string?> SelectKubernetesContextForDeployment();
    Task<bool> ApplyManifests(string context, string outputFolder);
    Task<bool> RemoveManifests(string context, string outputFolder);
}
