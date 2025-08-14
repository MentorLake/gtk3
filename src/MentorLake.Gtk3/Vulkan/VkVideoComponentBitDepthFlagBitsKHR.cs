namespace MentorLake.Vulkan;


public class VkVideoComponentBitDepthFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoComponentBitDepthFlagBitsKHRExtensions
{

	public static VkVideoComponentBitDepthFlagBitsKHR Dereference(this VkVideoComponentBitDepthFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoComponentBitDepthFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoComponentBitDepthFlagBitsKHRExterns
{
}


public struct VkVideoComponentBitDepthFlagBitsKHR
{
}
