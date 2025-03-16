namespace MentorLake.Vulkan;

public class VkPhysicalDevice16BitStorageFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevice16BitStorageFeaturesExtensions
{

	public static VkPhysicalDevice16BitStorageFeatures Dereference(this VkPhysicalDevice16BitStorageFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevice16BitStorageFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDevice16BitStorageFeaturesExterns
{
}

public struct VkPhysicalDevice16BitStorageFeatures
{
}
