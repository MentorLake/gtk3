namespace MentorLake.Vulkan;


public class VkPipelineRasterizationConservativeStateCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationConservativeStateCreateFlagsEXTExtensions
{

	public static VkPipelineRasterizationConservativeStateCreateFlagsEXT Dereference(this VkPipelineRasterizationConservativeStateCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationConservativeStateCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationConservativeStateCreateFlagsEXTExterns
{
}


public struct VkPipelineRasterizationConservativeStateCreateFlagsEXT
{
}
