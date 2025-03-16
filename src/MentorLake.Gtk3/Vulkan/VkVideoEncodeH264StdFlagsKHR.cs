namespace MentorLake.Vulkan;

public class VkVideoEncodeH264StdFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264StdFlagsKHRExtensions
{

	public static VkVideoEncodeH264StdFlagsKHR Dereference(this VkVideoEncodeH264StdFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264StdFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264StdFlagsKHRExterns
{
}

public struct VkVideoEncodeH264StdFlagsKHR
{
}
