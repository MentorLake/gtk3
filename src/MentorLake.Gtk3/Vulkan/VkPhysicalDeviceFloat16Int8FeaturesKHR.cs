namespace MentorLake.Vulkan;

public class VkPhysicalDeviceFloat16Int8FeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFloat16Int8FeaturesKHRExtensions
{

	public static VkPhysicalDeviceFloat16Int8FeaturesKHR Dereference(this VkPhysicalDeviceFloat16Int8FeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFloat16Int8FeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFloat16Int8FeaturesKHRExterns
{
}

public struct VkPhysicalDeviceFloat16Int8FeaturesKHR
{
}
