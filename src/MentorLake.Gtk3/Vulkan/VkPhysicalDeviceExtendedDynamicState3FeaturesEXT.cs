namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExtendedDynamicState3FeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExtendedDynamicState3FeaturesEXTExtensions
{

	public static VkPhysicalDeviceExtendedDynamicState3FeaturesEXT Dereference(this VkPhysicalDeviceExtendedDynamicState3FeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExtendedDynamicState3FeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExtendedDynamicState3FeaturesEXTExterns
{
}


public struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
{
}
