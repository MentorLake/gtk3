namespace MentorLake.Vulkan;

public class VkImageCompressionPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkImageCompressionPropertiesEXTExtensions
{

	public static VkImageCompressionPropertiesEXT Dereference(this VkImageCompressionPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCompressionPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkImageCompressionPropertiesEXTExterns
{
}

public struct VkImageCompressionPropertiesEXT
{
}
