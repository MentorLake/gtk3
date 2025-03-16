namespace MentorLake.Vulkan;

public class VkPhysicalDeviceLineRasterizationPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLineRasterizationPropertiesEXTExtensions
{

	public static VkPhysicalDeviceLineRasterizationPropertiesEXT Dereference(this VkPhysicalDeviceLineRasterizationPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLineRasterizationPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLineRasterizationPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceLineRasterizationPropertiesEXT
{
}
