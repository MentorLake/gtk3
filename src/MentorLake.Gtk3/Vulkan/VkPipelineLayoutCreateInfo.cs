namespace MentorLake.Vulkan;

public class VkPipelineLayoutCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineLayoutCreateInfoExtensions
{

	public static VkPipelineLayoutCreateInfo Dereference(this VkPipelineLayoutCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineLayoutCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineLayoutCreateInfoExterns
{
}

public struct VkPipelineLayoutCreateInfo
{
}
