namespace MentorLake.Vulkan;

public class VkVideoEncodeH265RateControlLayerInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265RateControlLayerInfoKHRExtensions
{

	public static VkVideoEncodeH265RateControlLayerInfoKHR Dereference(this VkVideoEncodeH265RateControlLayerInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265RateControlLayerInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265RateControlLayerInfoKHRExterns
{
}

public struct VkVideoEncodeH265RateControlLayerInfoKHR
{
}
