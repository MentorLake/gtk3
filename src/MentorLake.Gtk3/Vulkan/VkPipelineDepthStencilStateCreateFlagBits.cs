namespace MentorLake.Vulkan;

public class VkPipelineDepthStencilStateCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkPipelineDepthStencilStateCreateFlagBitsExtensions
{

	public static VkPipelineDepthStencilStateCreateFlagBits Dereference(this VkPipelineDepthStencilStateCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineDepthStencilStateCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkPipelineDepthStencilStateCreateFlagBitsExterns
{
}

public struct VkPipelineDepthStencilStateCreateFlagBits
{
}
