namespace MentorLake.Vulkan;

public class VkImageCompressionFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkImageCompressionFlagsEXTExtensions
{

	public static VkImageCompressionFlagsEXT Dereference(this VkImageCompressionFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCompressionFlagsEXT>(x.DangerousGetHandle());
}
internal class VkImageCompressionFlagsEXTExterns
{
}

public struct VkImageCompressionFlagsEXT
{
}
