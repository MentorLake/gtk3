namespace MentorLake.Vulkan;

public class VkVideoInlineQueryInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoInlineQueryInfoKHRExtensions
{

	public static VkVideoInlineQueryInfoKHR Dereference(this VkVideoInlineQueryInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoInlineQueryInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoInlineQueryInfoKHRExterns
{
}

public struct VkVideoInlineQueryInfoKHR
{
}
