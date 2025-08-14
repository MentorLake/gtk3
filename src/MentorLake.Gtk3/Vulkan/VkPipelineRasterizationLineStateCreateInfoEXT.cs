namespace MentorLake.Vulkan;


public class VkPipelineRasterizationLineStateCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationLineStateCreateInfoEXTExtensions
{

	public static VkPipelineRasterizationLineStateCreateInfoEXT Dereference(this VkPipelineRasterizationLineStateCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationLineStateCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationLineStateCreateInfoEXTExterns
{
}


public struct VkPipelineRasterizationLineStateCreateInfoEXT
{
}
