namespace MentorLake.Vulkan;


public class VkImageCopy2KHRHandle : BaseSafeHandle
{
}


public static class VkImageCopy2KHRExtensions
{

	public static VkImageCopy2KHR Dereference(this VkImageCopy2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCopy2KHR>(x.DangerousGetHandle());
}
internal class VkImageCopy2KHRExterns
{
}


public struct VkImageCopy2KHR
{
}
