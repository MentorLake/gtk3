namespace MentorLake.Vulkan;


public class VkVideoDecodeH265DpbSlotInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoDecodeH265DpbSlotInfoKHRExtensions
{

	public static VkVideoDecodeH265DpbSlotInfoKHR Dereference(this VkVideoDecodeH265DpbSlotInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoDecodeH265DpbSlotInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoDecodeH265DpbSlotInfoKHRExterns
{
}


public struct VkVideoDecodeH265DpbSlotInfoKHR
{
}
