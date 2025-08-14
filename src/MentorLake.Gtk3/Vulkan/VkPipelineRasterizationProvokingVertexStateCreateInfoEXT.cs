namespace MentorLake.Vulkan;


public class VkPipelineRasterizationProvokingVertexStateCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationProvokingVertexStateCreateInfoEXTExtensions
{

	public static VkPipelineRasterizationProvokingVertexStateCreateInfoEXT Dereference(this VkPipelineRasterizationProvokingVertexStateCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationProvokingVertexStateCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationProvokingVertexStateCreateInfoEXTExterns
{
}


public struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
{
}
