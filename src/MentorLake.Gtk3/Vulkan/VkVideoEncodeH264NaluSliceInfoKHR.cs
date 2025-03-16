namespace MentorLake.Vulkan;

public class VkVideoEncodeH264NaluSliceInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264NaluSliceInfoKHRExtensions
{

	public static VkVideoEncodeH264NaluSliceInfoKHR Dereference(this VkVideoEncodeH264NaluSliceInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264NaluSliceInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264NaluSliceInfoKHRExterns
{
}

public struct VkVideoEncodeH264NaluSliceInfoKHR
{
}
