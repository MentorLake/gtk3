namespace MentorLake.Vulkan;


public class VkPipelineDepthStencilStateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineDepthStencilStateCreateFlagsExtensions
{

	public static VkPipelineDepthStencilStateCreateFlags Dereference(this VkPipelineDepthStencilStateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineDepthStencilStateCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineDepthStencilStateCreateFlagsExterns
{
}


public struct VkPipelineDepthStencilStateCreateFlags
{
}
