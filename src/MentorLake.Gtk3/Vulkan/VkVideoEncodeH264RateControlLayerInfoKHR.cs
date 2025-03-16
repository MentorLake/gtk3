namespace MentorLake.Vulkan;

public class VkVideoEncodeH264RateControlLayerInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264RateControlLayerInfoKHRExtensions
{

	public static VkVideoEncodeH264RateControlLayerInfoKHR Dereference(this VkVideoEncodeH264RateControlLayerInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264RateControlLayerInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264RateControlLayerInfoKHRExterns
{
}

public struct VkVideoEncodeH264RateControlLayerInfoKHR
{
}
