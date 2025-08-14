namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExtendedDynamicState3PropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExtendedDynamicState3PropertiesEXTExtensions
{

	public static VkPhysicalDeviceExtendedDynamicState3PropertiesEXT Dereference(this VkPhysicalDeviceExtendedDynamicState3PropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExtendedDynamicState3PropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExtendedDynamicState3PropertiesEXTExterns
{
}


public struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT
{
}
