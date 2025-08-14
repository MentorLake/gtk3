namespace MentorLake.Vulkan;


public class VkComputePipelineCreateInfoHandle : BaseSafeHandle
{
}


public static class VkComputePipelineCreateInfoExtensions
{

	public static VkComputePipelineCreateInfo Dereference(this VkComputePipelineCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkComputePipelineCreateInfo>(x.DangerousGetHandle());
}
internal class VkComputePipelineCreateInfoExterns
{
}


public struct VkComputePipelineCreateInfo
{
}
