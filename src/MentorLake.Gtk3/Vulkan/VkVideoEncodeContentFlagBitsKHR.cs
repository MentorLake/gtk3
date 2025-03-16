namespace MentorLake.Vulkan;

public class VkVideoEncodeContentFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeContentFlagBitsKHRExtensions
{

	public static VkVideoEncodeContentFlagBitsKHR Dereference(this VkVideoEncodeContentFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeContentFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeContentFlagBitsKHRExterns
{
}

public struct VkVideoEncodeContentFlagBitsKHR
{
}
