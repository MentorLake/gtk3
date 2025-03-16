namespace MentorLake.Vulkan;

public class VkImageToMemoryCopyEXTHandle : BaseSafeHandle
{
}


public static class VkImageToMemoryCopyEXTExtensions
{

	public static VkImageToMemoryCopyEXT Dereference(this VkImageToMemoryCopyEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageToMemoryCopyEXT>(x.DangerousGetHandle());
}
internal class VkImageToMemoryCopyEXTExterns
{
}

public struct VkImageToMemoryCopyEXT
{
}
