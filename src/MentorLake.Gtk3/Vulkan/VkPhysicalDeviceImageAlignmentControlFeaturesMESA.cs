namespace MentorLake.Vulkan;

public class VkPhysicalDeviceImageAlignmentControlFeaturesMESAHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageAlignmentControlFeaturesMESAExtensions
{

	public static VkPhysicalDeviceImageAlignmentControlFeaturesMESA Dereference(this VkPhysicalDeviceImageAlignmentControlFeaturesMESAHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageAlignmentControlFeaturesMESA>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageAlignmentControlFeaturesMESAExterns
{
}

public struct VkPhysicalDeviceImageAlignmentControlFeaturesMESA
{
}
