namespace MentorLake.Vulkan;

public class VkPipelineRasterizationStateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationStateCreateFlagsExtensions
{

	public static VkPipelineRasterizationStateCreateFlags Dereference(this VkPipelineRasterizationStateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationStateCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationStateCreateFlagsExterns
{
}

public struct VkPipelineRasterizationStateCreateFlags
{
}
