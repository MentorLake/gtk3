namespace MentorLake.Vulkan;


public class VkPipelineVertexInputStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineVertexInputStateCreateInfoExtensions
{

	public static VkPipelineVertexInputStateCreateInfo Dereference(this VkPipelineVertexInputStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineVertexInputStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineVertexInputStateCreateInfoExterns
{
}


public struct VkPipelineVertexInputStateCreateInfo
{
}
