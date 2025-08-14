namespace MentorLake.Vulkan;


public class VkImageCompressionFixedRateFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkImageCompressionFixedRateFlagBitsEXTExtensions
{

	public static VkImageCompressionFixedRateFlagBitsEXT Dereference(this VkImageCompressionFixedRateFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCompressionFixedRateFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkImageCompressionFixedRateFlagBitsEXTExterns
{
}


public struct VkImageCompressionFixedRateFlagBitsEXT
{
}
