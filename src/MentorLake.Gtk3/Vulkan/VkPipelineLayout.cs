namespace MentorLake.Vulkan;


public class VkPipelineLayoutHandle : BaseSafeHandle
{
}


public static class VkPipelineLayoutExtensions
{

	public static VkPipelineLayout Dereference(this VkPipelineLayoutHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineLayout>(x.DangerousGetHandle());
}
internal class VkPipelineLayoutExterns
{
}


public struct VkPipelineLayout
{
}
