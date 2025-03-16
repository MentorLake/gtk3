namespace MentorLake.Vulkan;

public class VkImageFormatProperties2Handle : BaseSafeHandle
{
}


public static class VkImageFormatProperties2Extensions
{

	public static VkImageFormatProperties2 Dereference(this VkImageFormatProperties2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageFormatProperties2>(x.DangerousGetHandle());
}
internal class VkImageFormatProperties2Externs
{
}

public struct VkImageFormatProperties2
{
}
