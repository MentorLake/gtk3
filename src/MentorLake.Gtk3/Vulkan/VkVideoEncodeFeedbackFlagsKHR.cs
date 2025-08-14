namespace MentorLake.Vulkan;


public class VkVideoEncodeFeedbackFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeFeedbackFlagsKHRExtensions
{

	public static VkVideoEncodeFeedbackFlagsKHR Dereference(this VkVideoEncodeFeedbackFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeFeedbackFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeFeedbackFlagsKHRExterns
{
}


public struct VkVideoEncodeFeedbackFlagsKHR
{
}
