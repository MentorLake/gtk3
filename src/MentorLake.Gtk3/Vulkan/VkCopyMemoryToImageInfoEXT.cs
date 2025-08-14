namespace MentorLake.Vulkan;


public class VkCopyMemoryToImageInfoEXTHandle : BaseSafeHandle
{
}


public static class VkCopyMemoryToImageInfoEXTExtensions
{

	public static VkCopyMemoryToImageInfoEXT Dereference(this VkCopyMemoryToImageInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyMemoryToImageInfoEXT>(x.DangerousGetHandle());
}
internal class VkCopyMemoryToImageInfoEXTExterns
{
}


public struct VkCopyMemoryToImageInfoEXT
{
}
