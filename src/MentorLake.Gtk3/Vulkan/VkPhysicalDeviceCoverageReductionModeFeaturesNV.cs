namespace MentorLake.Vulkan;


public class VkPhysicalDeviceCoverageReductionModeFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCoverageReductionModeFeaturesNVExtensions
{

	public static VkPhysicalDeviceCoverageReductionModeFeaturesNV Dereference(this VkPhysicalDeviceCoverageReductionModeFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCoverageReductionModeFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCoverageReductionModeFeaturesNVExterns
{
}


public struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
{
}
