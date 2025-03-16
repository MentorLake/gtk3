namespace MentorLake.Vulkan;

public class VkVideoDecodeAV1DpbSlotInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeAV1DpbSlotInfoKHRExtensions
{

	public static VkVideoDecodeAV1DpbSlotInfoKHR Dereference(this VkVideoDecodeAV1DpbSlotInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeAV1DpbSlotInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeAV1DpbSlotInfoKHRExterns
{
}

public struct VkVideoDecodeAV1DpbSlotInfoKHR
{
}
