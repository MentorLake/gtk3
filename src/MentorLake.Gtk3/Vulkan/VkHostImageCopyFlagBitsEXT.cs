namespace MentorLake.Vulkan;


public class VkHostImageCopyFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkHostImageCopyFlagBitsEXTExtensions
{

	public static VkHostImageCopyFlagBitsEXT Dereference(this VkHostImageCopyFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkHostImageCopyFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkHostImageCopyFlagBitsEXTExterns
{
}


public struct VkHostImageCopyFlagBitsEXT
{
}
