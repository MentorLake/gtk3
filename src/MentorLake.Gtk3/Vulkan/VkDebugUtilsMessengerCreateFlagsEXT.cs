namespace MentorLake.Vulkan;


public class VkDebugUtilsMessengerCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkDebugUtilsMessengerCreateFlagsEXTExtensions
{

	public static VkDebugUtilsMessengerCreateFlagsEXT Dereference(this VkDebugUtilsMessengerCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugUtilsMessengerCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkDebugUtilsMessengerCreateFlagsEXTExterns
{
}


public struct VkDebugUtilsMessengerCreateFlagsEXT
{
}
