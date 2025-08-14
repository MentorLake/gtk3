namespace MentorLake.Vulkan;


public class VkPipelineDepthStencilStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineDepthStencilStateCreateInfoExtensions
{

	public static VkPipelineDepthStencilStateCreateInfo Dereference(this VkPipelineDepthStencilStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineDepthStencilStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineDepthStencilStateCreateInfoExterns
{
}


public struct VkPipelineDepthStencilStateCreateInfo
{
}
