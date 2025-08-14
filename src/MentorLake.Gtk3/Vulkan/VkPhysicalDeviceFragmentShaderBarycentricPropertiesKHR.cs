namespace MentorLake.Vulkan;


public class VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHRExtensions
{

	public static VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR Dereference(this VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHRExterns
{
}


public struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
{
}
