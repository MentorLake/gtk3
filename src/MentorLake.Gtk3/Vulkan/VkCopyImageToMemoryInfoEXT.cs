namespace MentorLake.Vulkan;

public class VkCopyImageToMemoryInfoEXTHandle : BaseSafeHandle
{
}


public static class VkCopyImageToMemoryInfoEXTExtensions
{

	public static VkCopyImageToMemoryInfoEXT Dereference(this VkCopyImageToMemoryInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyImageToMemoryInfoEXT>(x.DangerousGetHandle());
}
internal class VkCopyImageToMemoryInfoEXTExterns
{
}

public struct VkCopyImageToMemoryInfoEXT
{
}
