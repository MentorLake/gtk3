namespace MentorLake.Vulkan;


public class VkPhysicalDeviceCustomBorderColorFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCustomBorderColorFeaturesEXTExtensions
{

	public static VkPhysicalDeviceCustomBorderColorFeaturesEXT Dereference(this VkPhysicalDeviceCustomBorderColorFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCustomBorderColorFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCustomBorderColorFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
}
