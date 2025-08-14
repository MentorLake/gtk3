namespace MentorLake.Vulkan;


public class VkFormatProperties2Handle : BaseSafeHandle
{
}


public static class VkFormatProperties2Extensions
{

	public static VkFormatProperties2 Dereference(this VkFormatProperties2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatProperties2>(x.DangerousGetHandle());
}
internal class VkFormatProperties2Externs
{
}


public struct VkFormatProperties2
{
}
