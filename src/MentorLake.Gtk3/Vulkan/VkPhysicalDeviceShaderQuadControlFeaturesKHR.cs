namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderQuadControlFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderQuadControlFeaturesKHRExtensions
{

	public static VkPhysicalDeviceShaderQuadControlFeaturesKHR Dereference(this VkPhysicalDeviceShaderQuadControlFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderQuadControlFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderQuadControlFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceShaderQuadControlFeaturesKHR
{
}
