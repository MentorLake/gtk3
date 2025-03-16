namespace MentorLake.Vulkan;

public class VkPhysicalDevice8BitStorageFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevice8BitStorageFeaturesExtensions
{

	public static VkPhysicalDevice8BitStorageFeatures Dereference(this VkPhysicalDevice8BitStorageFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevice8BitStorageFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDevice8BitStorageFeaturesExterns
{
}

public struct VkPhysicalDevice8BitStorageFeatures
{
}
