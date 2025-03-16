namespace MentorLake.Vulkan;

public class VkVideoEncodeH264SessionParametersFeedbackInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264SessionParametersFeedbackInfoKHRExtensions
{

	public static VkVideoEncodeH264SessionParametersFeedbackInfoKHR Dereference(this VkVideoEncodeH264SessionParametersFeedbackInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264SessionParametersFeedbackInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264SessionParametersFeedbackInfoKHRExterns
{
}

public struct VkVideoEncodeH264SessionParametersFeedbackInfoKHR
{
}
