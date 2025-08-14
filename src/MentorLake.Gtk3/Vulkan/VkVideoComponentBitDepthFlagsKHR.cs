namespace MentorLake.Vulkan;


public class VkVideoComponentBitDepthFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoComponentBitDepthFlagsKHRExtensions
{

	public static VkVideoComponentBitDepthFlagsKHR Dereference(this VkVideoComponentBitDepthFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoComponentBitDepthFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoComponentBitDepthFlagsKHRExterns
{
}


public struct VkVideoComponentBitDepthFlagsKHR
{
}
