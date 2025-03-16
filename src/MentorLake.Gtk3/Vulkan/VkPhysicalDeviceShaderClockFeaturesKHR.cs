namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderClockFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderClockFeaturesKHRExtensions
{

	public static VkPhysicalDeviceShaderClockFeaturesKHR Dereference(this VkPhysicalDeviceShaderClockFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderClockFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderClockFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceShaderClockFeaturesKHR
{
}
