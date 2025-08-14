namespace MentorLake.Vulkan;


public class VkPipelineCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineCreateFlagsExtensions
{

	public static VkPipelineCreateFlags Dereference(this VkPipelineCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineCreateFlagsExterns
{
}


public struct VkPipelineCreateFlags
{
}
