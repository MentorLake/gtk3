namespace MentorLake.Vulkan;


public class VkPipelineCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkPipelineCreateFlagBitsExtensions
{

	public static VkPipelineCreateFlagBits Dereference(this VkPipelineCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkPipelineCreateFlagBitsExterns
{
}


public struct VkPipelineCreateFlagBits
{
}
