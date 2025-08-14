namespace MentorLake.Vulkan;


public class VkImageCompressionFixedRateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkImageCompressionFixedRateFlagsEXTExtensions
{

	public static VkImageCompressionFixedRateFlagsEXT Dereference(this VkImageCompressionFixedRateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCompressionFixedRateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkImageCompressionFixedRateFlagsEXTExterns
{
}


public struct VkImageCompressionFixedRateFlagsEXT
{
}
