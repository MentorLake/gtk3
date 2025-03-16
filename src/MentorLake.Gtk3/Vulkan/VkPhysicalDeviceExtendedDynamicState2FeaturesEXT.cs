namespace MentorLake.Vulkan;

public class VkPhysicalDeviceExtendedDynamicState2FeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExtendedDynamicState2FeaturesEXTExtensions
{

	public static VkPhysicalDeviceExtendedDynamicState2FeaturesEXT Dereference(this VkPhysicalDeviceExtendedDynamicState2FeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExtendedDynamicState2FeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExtendedDynamicState2FeaturesEXTExterns
{
}

public struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
{
}
