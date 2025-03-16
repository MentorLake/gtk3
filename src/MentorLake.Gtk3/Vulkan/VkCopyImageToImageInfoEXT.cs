namespace MentorLake.Vulkan;

public class VkCopyImageToImageInfoEXTHandle : BaseSafeHandle
{
}


public static class VkCopyImageToImageInfoEXTExtensions
{

	public static VkCopyImageToImageInfoEXT Dereference(this VkCopyImageToImageInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyImageToImageInfoEXT>(x.DangerousGetHandle());
}
internal class VkCopyImageToImageInfoEXTExterns
{
}

public struct VkCopyImageToImageInfoEXT
{
}
