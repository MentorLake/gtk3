namespace MentorLake.Vulkan;


public class VkImageFormatListCreateInfoHandle : BaseSafeHandle
{
}


public static class VkImageFormatListCreateInfoExtensions
{

	public static VkImageFormatListCreateInfo Dereference(this VkImageFormatListCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageFormatListCreateInfo>(x.DangerousGetHandle());
}
internal class VkImageFormatListCreateInfoExterns
{
}


public struct VkImageFormatListCreateInfo
{
}
