namespace MentorLake.Vulkan;

public class VkPhysicalDevicePCIBusInfoPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePCIBusInfoPropertiesEXTExtensions
{

	public static VkPhysicalDevicePCIBusInfoPropertiesEXT Dereference(this VkPhysicalDevicePCIBusInfoPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePCIBusInfoPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePCIBusInfoPropertiesEXTExterns
{
}

public struct VkPhysicalDevicePCIBusInfoPropertiesEXT
{
}
