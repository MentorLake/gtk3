namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExclusiveScissorFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExclusiveScissorFeaturesNVExtensions
{

	public static VkPhysicalDeviceExclusiveScissorFeaturesNV Dereference(this VkPhysicalDeviceExclusiveScissorFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExclusiveScissorFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExclusiveScissorFeaturesNVExterns
{
}


public struct VkPhysicalDeviceExclusiveScissorFeaturesNV
{
}
