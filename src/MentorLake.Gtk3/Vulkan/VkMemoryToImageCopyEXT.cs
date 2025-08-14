namespace MentorLake.Vulkan;


public class VkMemoryToImageCopyEXTHandle : BaseSafeHandle
{
}


public static class VkMemoryToImageCopyEXTExtensions
{

	public static VkMemoryToImageCopyEXT Dereference(this VkMemoryToImageCopyEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryToImageCopyEXT>(x.DangerousGetHandle());
}
internal class VkMemoryToImageCopyEXTExterns
{
}


public struct VkMemoryToImageCopyEXT
{
}
