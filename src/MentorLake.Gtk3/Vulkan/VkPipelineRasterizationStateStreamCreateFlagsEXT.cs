namespace MentorLake.Vulkan;


public class VkPipelineRasterizationStateStreamCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationStateStreamCreateFlagsEXTExtensions
{

	public static VkPipelineRasterizationStateStreamCreateFlagsEXT Dereference(this VkPipelineRasterizationStateStreamCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationStateStreamCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationStateStreamCreateFlagsEXTExterns
{
}


public struct VkPipelineRasterizationStateStreamCreateFlagsEXT
{
}
