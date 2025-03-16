namespace MentorLake.Vulkan;

public class VkTessellationDomainOriginHandle : BaseSafeHandle
{
}


public static class VkTessellationDomainOriginExtensions
{

	public static VkTessellationDomainOrigin Dereference(this VkTessellationDomainOriginHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTessellationDomainOrigin>(x.DangerousGetHandle());
}
internal class VkTessellationDomainOriginExterns
{
}

public struct VkTessellationDomainOrigin
{
}
