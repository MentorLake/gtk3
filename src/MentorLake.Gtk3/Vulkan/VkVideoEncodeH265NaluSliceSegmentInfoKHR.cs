namespace MentorLake.Vulkan;

public class VkVideoEncodeH265NaluSliceSegmentInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265NaluSliceSegmentInfoKHRExtensions
{

	public static VkVideoEncodeH265NaluSliceSegmentInfoKHR Dereference(this VkVideoEncodeH265NaluSliceSegmentInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265NaluSliceSegmentInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265NaluSliceSegmentInfoKHRExterns
{
}

public struct VkVideoEncodeH265NaluSliceSegmentInfoKHR
{
}
