namespace MentorLake.Vulkan;


public class VkVideoEncodeH265SessionParametersFeedbackInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265SessionParametersFeedbackInfoKHRExtensions
{

	public static VkVideoEncodeH265SessionParametersFeedbackInfoKHR Dereference(this VkVideoEncodeH265SessionParametersFeedbackInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265SessionParametersFeedbackInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265SessionParametersFeedbackInfoKHRExterns
{
}


public struct VkVideoEncodeH265SessionParametersFeedbackInfoKHR
{
}
