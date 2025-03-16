namespace MentorLake.Vulkan;

public class VkPipelineCreateFlagBits2KHRHandle : BaseSafeHandle
{
}


public static class VkPipelineCreateFlagBits2KHRExtensions
{

	public static VkPipelineCreateFlagBits2KHR Dereference(this VkPipelineCreateFlagBits2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCreateFlagBits2KHR>(x.DangerousGetHandle());
}
internal class VkPipelineCreateFlagBits2KHRExterns
{
}

public struct VkPipelineCreateFlagBits2KHR
{
}
