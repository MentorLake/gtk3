namespace MentorLake.Vulkan;


public class VkVideoChromaSubsamplingFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoChromaSubsamplingFlagBitsKHRExtensions
{

	public static VkVideoChromaSubsamplingFlagBitsKHR Dereference(this VkVideoChromaSubsamplingFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoChromaSubsamplingFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoChromaSubsamplingFlagBitsKHRExterns
{
}


public struct VkVideoChromaSubsamplingFlagBitsKHR
{
}
