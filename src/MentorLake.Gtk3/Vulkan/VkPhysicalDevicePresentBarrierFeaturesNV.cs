namespace MentorLake.Vulkan;

public class VkPhysicalDevicePresentBarrierFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePresentBarrierFeaturesNVExtensions
{

	public static VkPhysicalDevicePresentBarrierFeaturesNV Dereference(this VkPhysicalDevicePresentBarrierFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePresentBarrierFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePresentBarrierFeaturesNVExterns
{
}

public struct VkPhysicalDevicePresentBarrierFeaturesNV
{
}
