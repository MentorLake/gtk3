namespace MentorLake.Vulkan;

public class VkVideoEncodeContentFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeContentFlagsKHRExtensions
{

	public static VkVideoEncodeContentFlagsKHR Dereference(this VkVideoEncodeContentFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeContentFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeContentFlagsKHRExterns
{
}

public struct VkVideoEncodeContentFlagsKHR
{
}
