namespace MentorLake.Vulkan;


public class VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXTExtensions
{

	public static VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT Dereference(this VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXTExterns
{
}


public struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
{
}
