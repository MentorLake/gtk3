namespace MentorLake.Vulkan;


public class VkPipelineLayoutCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkPipelineLayoutCreateFlagBitsExtensions
{

	public static VkPipelineLayoutCreateFlagBits Dereference(this VkPipelineLayoutCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineLayoutCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkPipelineLayoutCreateFlagBitsExterns
{
}


public struct VkPipelineLayoutCreateFlagBits
{
}
