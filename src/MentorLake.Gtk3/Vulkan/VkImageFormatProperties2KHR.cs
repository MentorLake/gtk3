namespace MentorLake.Vulkan;

public class VkImageFormatProperties2KHRHandle : BaseSafeHandle
{
}


public static class VkImageFormatProperties2KHRExtensions
{

	public static VkImageFormatProperties2KHR Dereference(this VkImageFormatProperties2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageFormatProperties2KHR>(x.DangerousGetHandle());
}
internal class VkImageFormatProperties2KHRExterns
{
}

public struct VkImageFormatProperties2KHR
{
}
