namespace MentorLake.Vulkan;


public class VkVideoDecodeH264DpbSlotInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH264DpbSlotInfoKHRExtensions
{

	public static VkVideoDecodeH264DpbSlotInfoKHR Dereference(this VkVideoDecodeH264DpbSlotInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH264DpbSlotInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH264DpbSlotInfoKHRExterns
{
}


public struct VkVideoDecodeH264DpbSlotInfoKHR
{
}
