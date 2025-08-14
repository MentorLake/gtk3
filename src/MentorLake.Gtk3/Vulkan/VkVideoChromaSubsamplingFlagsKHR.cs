namespace MentorLake.Vulkan;


public class VkVideoChromaSubsamplingFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoChromaSubsamplingFlagsKHRExtensions
{

	public static VkVideoChromaSubsamplingFlagsKHR Dereference(this VkVideoChromaSubsamplingFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoChromaSubsamplingFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoChromaSubsamplingFlagsKHRExterns
{
}


public struct VkVideoChromaSubsamplingFlagsKHR
{
}
