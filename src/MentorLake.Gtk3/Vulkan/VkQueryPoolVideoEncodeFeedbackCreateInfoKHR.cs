namespace MentorLake.Vulkan;


public class VkQueryPoolVideoEncodeFeedbackCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkQueryPoolVideoEncodeFeedbackCreateInfoKHRExtensions
{

	public static VkQueryPoolVideoEncodeFeedbackCreateInfoKHR Dereference(this VkQueryPoolVideoEncodeFeedbackCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPoolVideoEncodeFeedbackCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkQueryPoolVideoEncodeFeedbackCreateInfoKHRExterns
{
}


public struct VkQueryPoolVideoEncodeFeedbackCreateInfoKHR
{
}
