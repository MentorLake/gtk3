namespace MentorLake.Vulkan;

public class VkPipelineVertexInputStateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineVertexInputStateCreateFlagsExtensions
{

	public static VkPipelineVertexInputStateCreateFlags Dereference(this VkPipelineVertexInputStateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineVertexInputStateCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineVertexInputStateCreateFlagsExterns
{
}

public struct VkPipelineVertexInputStateCreateFlags
{
}
