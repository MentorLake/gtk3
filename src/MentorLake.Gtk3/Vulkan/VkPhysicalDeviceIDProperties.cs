namespace MentorLake.Vulkan;

public class VkPhysicalDeviceIDPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceIDPropertiesExtensions
{

	public static VkPhysicalDeviceIDProperties Dereference(this VkPhysicalDeviceIDPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceIDProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceIDPropertiesExterns
{
}

public struct VkPhysicalDeviceIDProperties
{
}
