namespace MentorLake.Vulkan;


public class VkPhysicalDeviceCopyMemoryIndirectFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCopyMemoryIndirectFeaturesNVExtensions
{

	public static VkPhysicalDeviceCopyMemoryIndirectFeaturesNV Dereference(this VkPhysicalDeviceCopyMemoryIndirectFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCopyMemoryIndirectFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCopyMemoryIndirectFeaturesNVExterns
{
}


public struct VkPhysicalDeviceCopyMemoryIndirectFeaturesNV
{
}
