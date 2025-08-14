namespace MentorLake.Vulkan;


public class VkPipelineRasterizationConservativeStateCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationConservativeStateCreateInfoEXTExtensions
{

	public static VkPipelineRasterizationConservativeStateCreateInfoEXT Dereference(this VkPipelineRasterizationConservativeStateCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationConservativeStateCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationConservativeStateCreateInfoEXTExterns
{
}


public struct VkPipelineRasterizationConservativeStateCreateInfoEXT
{
}
