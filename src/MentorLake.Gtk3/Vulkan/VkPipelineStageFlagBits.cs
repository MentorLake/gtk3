namespace MentorLake.Vulkan;


public class VkPipelineStageFlagBitsHandle : BaseSafeHandle
{
}


public static class VkPipelineStageFlagBitsExtensions
{

	public static VkPipelineStageFlagBits Dereference(this VkPipelineStageFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineStageFlagBits>(x.DangerousGetHandle());
}
internal class VkPipelineStageFlagBitsExterns
{
}


public struct VkPipelineStageFlagBits
{
}
