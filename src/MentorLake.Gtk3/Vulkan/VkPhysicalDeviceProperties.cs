namespace MentorLake.Vulkan;

public class VkPhysicalDevicePropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePropertiesExtensions
{

	public static VkPhysicalDeviceProperties Dereference(this VkPhysicalDevicePropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePropertiesExterns
{
}

public struct VkPhysicalDeviceProperties
{
}
