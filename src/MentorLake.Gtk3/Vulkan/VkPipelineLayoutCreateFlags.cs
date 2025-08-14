namespace MentorLake.Vulkan;


public class VkPipelineLayoutCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineLayoutCreateFlagsExtensions
{

	public static VkPipelineLayoutCreateFlags Dereference(this VkPipelineLayoutCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineLayoutCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineLayoutCreateFlagsExterns
{
}


public struct VkPipelineLayoutCreateFlags
{
}
