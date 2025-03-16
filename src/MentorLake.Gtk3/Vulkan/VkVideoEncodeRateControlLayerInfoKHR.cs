namespace MentorLake.Vulkan;

public class VkVideoEncodeRateControlLayerInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeRateControlLayerInfoKHRExtensions
{

	public static VkVideoEncodeRateControlLayerInfoKHR Dereference(this VkVideoEncodeRateControlLayerInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeRateControlLayerInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeRateControlLayerInfoKHRExterns
{
}

public struct VkVideoEncodeRateControlLayerInfoKHR
{
}
