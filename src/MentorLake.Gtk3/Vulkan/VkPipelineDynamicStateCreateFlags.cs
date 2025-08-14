namespace MentorLake.Vulkan;


public class VkPipelineDynamicStateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineDynamicStateCreateFlagsExtensions
{

	public static VkPipelineDynamicStateCreateFlags Dereference(this VkPipelineDynamicStateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineDynamicStateCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineDynamicStateCreateFlagsExterns
{
}


public struct VkPipelineDynamicStateCreateFlags
{
}
