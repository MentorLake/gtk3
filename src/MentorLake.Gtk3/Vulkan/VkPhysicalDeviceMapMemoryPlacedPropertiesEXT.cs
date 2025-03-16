namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMapMemoryPlacedPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMapMemoryPlacedPropertiesEXTExtensions
{

	public static VkPhysicalDeviceMapMemoryPlacedPropertiesEXT Dereference(this VkPhysicalDeviceMapMemoryPlacedPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMapMemoryPlacedPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMapMemoryPlacedPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceMapMemoryPlacedPropertiesEXT
{
}
