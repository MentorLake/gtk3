namespace MentorLake.Vulkan;


public class VkDebugUtilsMessengerCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsMessengerCreateInfoEXTExtensions
{

	public static VkDebugUtilsMessengerCreateInfoEXT Dereference(this VkDebugUtilsMessengerCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsMessengerCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsMessengerCreateInfoEXTExterns
{
}


public struct VkDebugUtilsMessengerCreateInfoEXT
{
}
