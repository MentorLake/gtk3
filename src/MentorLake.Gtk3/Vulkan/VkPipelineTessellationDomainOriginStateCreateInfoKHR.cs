namespace MentorLake.Vulkan;

public class VkPipelineTessellationDomainOriginStateCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineTessellationDomainOriginStateCreateInfoKHRExtensions
{

	public static VkPipelineTessellationDomainOriginStateCreateInfoKHR Dereference(this VkPipelineTessellationDomainOriginStateCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineTessellationDomainOriginStateCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkPipelineTessellationDomainOriginStateCreateInfoKHRExterns
{
}

public struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
{
}
