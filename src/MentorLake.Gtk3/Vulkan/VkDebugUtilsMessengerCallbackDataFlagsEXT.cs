namespace MentorLake.Vulkan;

public class VkDebugUtilsMessengerCallbackDataFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsMessengerCallbackDataFlagsEXTExtensions
{

	public static VkDebugUtilsMessengerCallbackDataFlagsEXT Dereference(this VkDebugUtilsMessengerCallbackDataFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsMessengerCallbackDataFlagsEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsMessengerCallbackDataFlagsEXTExterns
{
}

public struct VkDebugUtilsMessengerCallbackDataFlagsEXT
{
}
