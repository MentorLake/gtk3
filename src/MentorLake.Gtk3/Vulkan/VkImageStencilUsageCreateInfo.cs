namespace MentorLake.Vulkan;


public class VkImageStencilUsageCreateInfoHandle : BaseSafeHandle
{
}


public static class VkImageStencilUsageCreateInfoExtensions
{

	public static VkImageStencilUsageCreateInfo Dereference(this VkImageStencilUsageCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageStencilUsageCreateInfo>(x.DangerousGetHandle());
}
internal class VkImageStencilUsageCreateInfoExterns
{
}


public struct VkImageStencilUsageCreateInfo
{
}
