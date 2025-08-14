namespace MentorLake.Vulkan;


public class VkPhysicalDevice8BitStorageFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevice8BitStorageFeaturesKHRExtensions
{

	public static VkPhysicalDevice8BitStorageFeaturesKHR Dereference(this VkPhysicalDevice8BitStorageFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevice8BitStorageFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDevice8BitStorageFeaturesKHRExterns
{
}


public struct VkPhysicalDevice8BitStorageFeaturesKHR
{
}
