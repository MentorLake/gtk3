namespace MentorLake.Vulkan;

public class VkVideoEncodeH265QpKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265QpKHRExtensions
{

	public static VkVideoEncodeH265QpKHR Dereference(this VkVideoEncodeH265QpKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265QpKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265QpKHRExterns
{
}

public struct VkVideoEncodeH265QpKHR
{
}
