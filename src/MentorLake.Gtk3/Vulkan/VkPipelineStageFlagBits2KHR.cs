namespace MentorLake.Vulkan;


public class VkPipelineStageFlagBits2KHRHandle : BaseSafeHandle
{
}


public static class VkPipelineStageFlagBits2KHRExtensions
{

	public static VkPipelineStageFlagBits2KHR Dereference(this VkPipelineStageFlagBits2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineStageFlagBits2KHR>(x.DangerousGetHandle());
}
internal class VkPipelineStageFlagBits2KHRExterns
{
}


public struct VkPipelineStageFlagBits2KHR
{
}
