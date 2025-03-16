namespace MentorLake.Vulkan;

public class VkVideoEncodeInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeInfoKHRExtensions
{

	public static VkVideoEncodeInfoKHR Dereference(this VkVideoEncodeInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeInfoKHRExterns
{
}

public struct VkVideoEncodeInfoKHR
{
}
