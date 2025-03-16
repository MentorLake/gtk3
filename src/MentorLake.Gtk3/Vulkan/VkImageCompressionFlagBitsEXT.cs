namespace MentorLake.Vulkan;

public class VkImageCompressionFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkImageCompressionFlagBitsEXTExtensions
{

	public static VkImageCompressionFlagBitsEXT Dereference(this VkImageCompressionFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCompressionFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkImageCompressionFlagBitsEXTExterns
{
}

public struct VkImageCompressionFlagBitsEXT
{
}
