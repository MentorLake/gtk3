namespace MentorLake.Vulkan;


public class VkPipelineRasterizationStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationStateCreateInfoExtensions
{

	public static VkPipelineRasterizationStateCreateInfo Dereference(this VkPipelineRasterizationStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationStateCreateInfoExterns
{
}


public struct VkPipelineRasterizationStateCreateInfo
{
}
