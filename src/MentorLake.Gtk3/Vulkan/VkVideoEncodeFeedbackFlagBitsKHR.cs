namespace MentorLake.Vulkan;

public class VkVideoEncodeFeedbackFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeFeedbackFlagBitsKHRExtensions
{

	public static VkVideoEncodeFeedbackFlagBitsKHR Dereference(this VkVideoEncodeFeedbackFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeFeedbackFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeFeedbackFlagBitsKHRExterns
{
}

public struct VkVideoEncodeFeedbackFlagBitsKHR
{
}
