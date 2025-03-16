namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMultiDrawFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMultiDrawFeaturesEXTExtensions
{

	public static VkPhysicalDeviceMultiDrawFeaturesEXT Dereference(this VkPhysicalDeviceMultiDrawFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMultiDrawFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMultiDrawFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceMultiDrawFeaturesEXT
{
}
