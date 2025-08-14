namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExtendedDynamicStateFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExtendedDynamicStateFeaturesEXTExtensions
{

	public static VkPhysicalDeviceExtendedDynamicStateFeaturesEXT Dereference(this VkPhysicalDeviceExtendedDynamicStateFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExtendedDynamicStateFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExtendedDynamicStateFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
{
}
