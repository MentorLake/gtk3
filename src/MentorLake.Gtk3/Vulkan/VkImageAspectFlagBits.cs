namespace MentorLake.Vulkan;

public class VkImageAspectFlagBitsHandle : BaseSafeHandle
{
}


public static class VkImageAspectFlagBitsExtensions
{

	public static VkImageAspectFlagBits Dereference(this VkImageAspectFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageAspectFlagBits>(x.DangerousGetHandle());
}
internal class VkImageAspectFlagBitsExterns
{
}

public struct VkImageAspectFlagBits
{
}
