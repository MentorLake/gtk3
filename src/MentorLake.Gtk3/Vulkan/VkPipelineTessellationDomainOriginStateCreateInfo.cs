namespace MentorLake.Vulkan;


public class VkPipelineTessellationDomainOriginStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineTessellationDomainOriginStateCreateInfoExtensions
{

	public static VkPipelineTessellationDomainOriginStateCreateInfo Dereference(this VkPipelineTessellationDomainOriginStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineTessellationDomainOriginStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineTessellationDomainOriginStateCreateInfoExterns
{
}


public struct VkPipelineTessellationDomainOriginStateCreateInfo
{
}
