namespace MentorLake.Vulkan;


public class VkPipelineColorBlendStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineColorBlendStateCreateInfoExtensions
{

	public static VkPipelineColorBlendStateCreateInfo Dereference(this VkPipelineColorBlendStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineColorBlendStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineColorBlendStateCreateInfoExterns
{
}


public struct VkPipelineColorBlendStateCreateInfo
{
}
