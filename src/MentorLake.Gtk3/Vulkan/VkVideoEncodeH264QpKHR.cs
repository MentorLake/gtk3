namespace MentorLake.Vulkan;

public class VkVideoEncodeH264QpKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264QpKHRExtensions
{

	public static VkVideoEncodeH264QpKHR Dereference(this VkVideoEncodeH264QpKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264QpKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264QpKHRExterns
{
}

public struct VkVideoEncodeH264QpKHR
{
}
