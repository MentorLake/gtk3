namespace MentorLake.Vulkan;

public class VkVideoEncodeTuningModeKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeTuningModeKHRExtensions
{

	public static VkVideoEncodeTuningModeKHR Dereference(this VkVideoEncodeTuningModeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeTuningModeKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeTuningModeKHRExterns
{
}

public struct VkVideoEncodeTuningModeKHR
{
}
