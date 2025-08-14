namespace MentorLake.Vulkan;


public class VkDebugUtilsMessengerCallbackDataEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsMessengerCallbackDataEXTExtensions
{

	public static VkDebugUtilsMessengerCallbackDataEXT Dereference(this VkDebugUtilsMessengerCallbackDataEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsMessengerCallbackDataEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsMessengerCallbackDataEXTExterns
{
}


public struct VkDebugUtilsMessengerCallbackDataEXT
{
}
