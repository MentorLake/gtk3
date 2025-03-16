namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderFloat16Int8FeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderFloat16Int8FeaturesKHRExtensions
{

	public static VkPhysicalDeviceShaderFloat16Int8FeaturesKHR Dereference(this VkPhysicalDeviceShaderFloat16Int8FeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderFloat16Int8FeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderFloat16Int8FeaturesKHRExterns
{
}

public struct VkPhysicalDeviceShaderFloat16Int8FeaturesKHR
{
}
