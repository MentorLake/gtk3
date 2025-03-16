namespace MentorLake.Vulkan;

public class VkImageCopy2Handle : BaseSafeHandle
{
}


public static class VkImageCopy2Extensions
{

	public static VkImageCopy2 Dereference(this VkImageCopy2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCopy2>(x.DangerousGetHandle());
}
internal class VkImageCopy2Externs
{
}

public struct VkImageCopy2
{
}
