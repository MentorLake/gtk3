namespace MentorLake.Vulkan;


public class VkPhysicalDeviceCooperativeMatrixFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCooperativeMatrixFeaturesNVExtensions
{

	public static VkPhysicalDeviceCooperativeMatrixFeaturesNV Dereference(this VkPhysicalDeviceCooperativeMatrixFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCooperativeMatrixFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCooperativeMatrixFeaturesNVExterns
{
}


public struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
{
}
