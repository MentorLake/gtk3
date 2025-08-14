namespace MentorLake.Vulkan;


public class VkDebugUtilsMessageTypeFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsMessageTypeFlagsEXTExtensions
{

	public static VkDebugUtilsMessageTypeFlagsEXT Dereference(this VkDebugUtilsMessageTypeFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsMessageTypeFlagsEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsMessageTypeFlagsEXTExterns
{
}


public struct VkDebugUtilsMessageTypeFlagsEXT
{
}
