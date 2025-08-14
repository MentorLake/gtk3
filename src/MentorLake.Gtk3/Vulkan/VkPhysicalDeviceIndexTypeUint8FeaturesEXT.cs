namespace MentorLake.Vulkan;


public class VkPhysicalDeviceIndexTypeUint8FeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceIndexTypeUint8FeaturesEXTExtensions
{

	public static VkPhysicalDeviceIndexTypeUint8FeaturesEXT Dereference(this VkPhysicalDeviceIndexTypeUint8FeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceIndexTypeUint8FeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceIndexTypeUint8FeaturesEXTExterns
{
}


public struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
}
