namespace MentorLake.Vulkan;

public class VkDebugUtilsMessengerEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsMessengerEXTExtensions
{

	public static VkDebugUtilsMessengerEXT Dereference(this VkDebugUtilsMessengerEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsMessengerEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsMessengerEXTExterns
{
}

public struct VkDebugUtilsMessengerEXT
{
}
