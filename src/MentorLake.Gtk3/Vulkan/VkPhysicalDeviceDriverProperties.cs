namespace MentorLake.Vulkan;

public class VkPhysicalDeviceDriverPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDriverPropertiesExtensions
{

	public static VkPhysicalDeviceDriverProperties Dereference(this VkPhysicalDeviceDriverPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDriverProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDriverPropertiesExterns
{
}

public struct VkPhysicalDeviceDriverProperties
{
}
