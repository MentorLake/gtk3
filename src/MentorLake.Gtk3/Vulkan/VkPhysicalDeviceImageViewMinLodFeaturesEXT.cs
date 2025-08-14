namespace MentorLake.Vulkan;


public class VkPhysicalDeviceImageViewMinLodFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageViewMinLodFeaturesEXTExtensions
{

	public static VkPhysicalDeviceImageViewMinLodFeaturesEXT Dereference(this VkPhysicalDeviceImageViewMinLodFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageViewMinLodFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageViewMinLodFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
{
}
