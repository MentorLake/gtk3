namespace MentorLake.Vulkan;


public class VkPipelineRasterizationStateRasterizationOrderAMDHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationStateRasterizationOrderAMDExtensions
{

	public static VkPipelineRasterizationStateRasterizationOrderAMD Dereference(this VkPipelineRasterizationStateRasterizationOrderAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationStateRasterizationOrderAMD>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationStateRasterizationOrderAMDExterns
{
}


public struct VkPipelineRasterizationStateRasterizationOrderAMD
{
}
