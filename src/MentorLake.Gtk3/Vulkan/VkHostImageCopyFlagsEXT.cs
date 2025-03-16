namespace MentorLake.Vulkan;

public class VkHostImageCopyFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkHostImageCopyFlagsEXTExtensions
{

	public static VkHostImageCopyFlagsEXT Dereference(this VkHostImageCopyFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkHostImageCopyFlagsEXT>(x.DangerousGetHandle());
}
internal class VkHostImageCopyFlagsEXTExterns
{
}

public struct VkHostImageCopyFlagsEXT
{
}
