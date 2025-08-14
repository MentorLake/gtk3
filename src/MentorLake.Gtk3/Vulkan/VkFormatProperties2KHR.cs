namespace MentorLake.Vulkan;


public class VkFormatProperties2KHRHandle : BaseSafeHandle
{
}


public static class VkFormatProperties2KHRExtensions
{

	public static VkFormatProperties2KHR Dereference(this VkFormatProperties2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatProperties2KHR>(x.DangerousGetHandle());
}
internal class VkFormatProperties2KHRExterns
{
}


public struct VkFormatProperties2KHR
{
}
