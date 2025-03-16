namespace MentorLake.Vulkan;

public class VkVideoEncodeH265DpbSlotInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265DpbSlotInfoKHRExtensions
{

	public static VkVideoEncodeH265DpbSlotInfoKHR Dereference(this VkVideoEncodeH265DpbSlotInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265DpbSlotInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265DpbSlotInfoKHRExterns
{
}

public struct VkVideoEncodeH265DpbSlotInfoKHR
{
}
