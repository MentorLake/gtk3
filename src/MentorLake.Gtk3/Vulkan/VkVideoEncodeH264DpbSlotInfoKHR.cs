namespace MentorLake.Vulkan;

public class VkVideoEncodeH264DpbSlotInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264DpbSlotInfoKHRExtensions
{

	public static VkVideoEncodeH264DpbSlotInfoKHR Dereference(this VkVideoEncodeH264DpbSlotInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264DpbSlotInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264DpbSlotInfoKHRExterns
{
}

public struct VkVideoEncodeH264DpbSlotInfoKHR
{
}
