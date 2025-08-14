namespace MentorLake.Vulkan;


public class VkVideoDecodeAV1ProfileInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeAV1ProfileInfoKHRExtensions
{

	public static VkVideoDecodeAV1ProfileInfoKHR Dereference(this VkVideoDecodeAV1ProfileInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeAV1ProfileInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeAV1ProfileInfoKHRExterns
{
}


public struct VkVideoDecodeAV1ProfileInfoKHR
{
}
