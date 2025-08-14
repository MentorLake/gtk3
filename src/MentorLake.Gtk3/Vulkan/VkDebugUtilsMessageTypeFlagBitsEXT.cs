namespace MentorLake.Vulkan;


public class VkDebugUtilsMessageTypeFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsMessageTypeFlagBitsEXTExtensions
{

	public static VkDebugUtilsMessageTypeFlagBitsEXT Dereference(this VkDebugUtilsMessageTypeFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsMessageTypeFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsMessageTypeFlagBitsEXTExterns
{
}


public struct VkDebugUtilsMessageTypeFlagBitsEXT
{
}
