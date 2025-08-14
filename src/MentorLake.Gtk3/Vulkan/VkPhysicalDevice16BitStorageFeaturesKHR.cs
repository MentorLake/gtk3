namespace MentorLake.Vulkan;


public class VkPhysicalDevice16BitStorageFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevice16BitStorageFeaturesKHRExtensions
{

	public static VkPhysicalDevice16BitStorageFeaturesKHR Dereference(this VkPhysicalDevice16BitStorageFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevice16BitStorageFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDevice16BitStorageFeaturesKHRExterns
{
}


public struct VkPhysicalDevice16BitStorageFeaturesKHR
{
}
