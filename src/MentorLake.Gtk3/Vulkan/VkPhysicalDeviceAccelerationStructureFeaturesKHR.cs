namespace MentorLake.Vulkan;

public class VkPhysicalDeviceAccelerationStructureFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceAccelerationStructureFeaturesKHRExtensions
{

	public static VkPhysicalDeviceAccelerationStructureFeaturesKHR Dereference(this VkPhysicalDeviceAccelerationStructureFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceAccelerationStructureFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceAccelerationStructureFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
{
}
