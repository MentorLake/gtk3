namespace MentorLake.Vulkan;

public class VkTessellationDomainOriginKHRHandle : BaseSafeHandle
{
}


public static class VkTessellationDomainOriginKHRExtensions
{

	public static VkTessellationDomainOriginKHR Dereference(this VkTessellationDomainOriginKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTessellationDomainOriginKHR>(x.DangerousGetHandle());
}
internal class VkTessellationDomainOriginKHRExterns
{
}

public struct VkTessellationDomainOriginKHR
{
}
