namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMapMemoryPlacedFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMapMemoryPlacedFeaturesEXTExtensions
{

	public static VkPhysicalDeviceMapMemoryPlacedFeaturesEXT Dereference(this VkPhysicalDeviceMapMemoryPlacedFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMapMemoryPlacedFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMapMemoryPlacedFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceMapMemoryPlacedFeaturesEXT
{
}
