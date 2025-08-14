namespace MentorLake.Vulkan;


public class VkImageCompressionControlEXTHandle : BaseSafeHandle
{
}


public static class VkImageCompressionControlEXTExtensions
{

	public static VkImageCompressionControlEXT Dereference(this VkImageCompressionControlEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCompressionControlEXT>(x.DangerousGetHandle());
}
internal class VkImageCompressionControlEXTExterns
{
}


public struct VkImageCompressionControlEXT
{
}
