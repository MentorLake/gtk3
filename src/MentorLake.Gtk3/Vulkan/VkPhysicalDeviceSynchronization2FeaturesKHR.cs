namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSynchronization2FeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSynchronization2FeaturesKHRExtensions
{

	public static VkPhysicalDeviceSynchronization2FeaturesKHR Dereference(this VkPhysicalDeviceSynchronization2FeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSynchronization2FeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSynchronization2FeaturesKHRExterns
{
}

public struct VkPhysicalDeviceSynchronization2FeaturesKHR
{
}
