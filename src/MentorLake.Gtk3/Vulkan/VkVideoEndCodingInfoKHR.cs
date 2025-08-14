namespace MentorLake.Vulkan;


public class VkVideoEndCodingInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEndCodingInfoKHRExtensions
{

	public static VkVideoEndCodingInfoKHR Dereference(this VkVideoEndCodingInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEndCodingInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEndCodingInfoKHRExterns
{
}


public struct VkVideoEndCodingInfoKHR
{
}
