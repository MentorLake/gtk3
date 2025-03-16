namespace MentorLake.Vulkan;

public class VkPhysicalDeviceLineRasterizationFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLineRasterizationFeaturesEXTExtensions
{

	public static VkPhysicalDeviceLineRasterizationFeaturesEXT Dereference(this VkPhysicalDeviceLineRasterizationFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLineRasterizationFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLineRasterizationFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
}
