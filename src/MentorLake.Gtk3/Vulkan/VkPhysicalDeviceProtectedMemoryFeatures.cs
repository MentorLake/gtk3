namespace MentorLake.Vulkan;

public class VkPhysicalDeviceProtectedMemoryFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceProtectedMemoryFeaturesExtensions
{

	public static VkPhysicalDeviceProtectedMemoryFeatures Dereference(this VkPhysicalDeviceProtectedMemoryFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceProtectedMemoryFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceProtectedMemoryFeaturesExterns
{
}

public struct VkPhysicalDeviceProtectedMemoryFeatures
{
}
