namespace MentorLake.Vulkan;

public class VkPhysicalDeviceAccelerationStructurePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceAccelerationStructurePropertiesKHRExtensions
{

	public static VkPhysicalDeviceAccelerationStructurePropertiesKHR Dereference(this VkPhysicalDeviceAccelerationStructurePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceAccelerationStructurePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceAccelerationStructurePropertiesKHRExterns
{
}

public struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
}
