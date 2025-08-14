namespace MentorLake.Vulkan;


public class VkPipelineRenderingCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineRenderingCreateInfoExtensions
{

	public static VkPipelineRenderingCreateInfo Dereference(this VkPipelineRenderingCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRenderingCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineRenderingCreateInfoExterns
{
}


public struct VkPipelineRenderingCreateInfo
{
}
