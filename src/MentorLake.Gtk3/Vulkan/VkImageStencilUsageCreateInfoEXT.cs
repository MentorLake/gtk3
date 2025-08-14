namespace MentorLake.Vulkan;


public class VkImageStencilUsageCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkImageStencilUsageCreateInfoEXTExtensions
{

	public static VkImageStencilUsageCreateInfoEXT Dereference(this VkImageStencilUsageCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageStencilUsageCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkImageStencilUsageCreateInfoEXTExterns
{
}


public struct VkImageStencilUsageCreateInfoEXT
{
}
