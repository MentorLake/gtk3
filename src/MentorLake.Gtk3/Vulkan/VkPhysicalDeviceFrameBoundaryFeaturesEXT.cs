namespace MentorLake.Vulkan;

public class VkPhysicalDeviceFrameBoundaryFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFrameBoundaryFeaturesEXTExtensions
{

	public static VkPhysicalDeviceFrameBoundaryFeaturesEXT Dereference(this VkPhysicalDeviceFrameBoundaryFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFrameBoundaryFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFrameBoundaryFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceFrameBoundaryFeaturesEXT
{
}
