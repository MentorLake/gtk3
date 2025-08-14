namespace MentorLake.Vulkan;


public class VkVideoEncodeSessionParametersFeedbackInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeSessionParametersFeedbackInfoKHRExtensions
{

	public static VkVideoEncodeSessionParametersFeedbackInfoKHR Dereference(this VkVideoEncodeSessionParametersFeedbackInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeSessionParametersFeedbackInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeSessionParametersFeedbackInfoKHRExterns
{
}


public struct VkVideoEncodeSessionParametersFeedbackInfoKHR
{
}
