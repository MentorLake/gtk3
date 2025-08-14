namespace MentorLake.Vulkan;


public class VkPhysicalDeviceFeatures2KHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFeatures2KHRExtensions
{

	public static VkPhysicalDeviceFeatures2KHR Dereference(this VkPhysicalDeviceFeatures2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFeatures2KHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFeatures2KHRExterns
{
}


public struct VkPhysicalDeviceFeatures2KHR
{
}
