namespace MentorLake.Vulkan;

public class VkPhysicalDeviceCooperativeMatrixFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCooperativeMatrixFeaturesKHRExtensions
{

	public static VkPhysicalDeviceCooperativeMatrixFeaturesKHR Dereference(this VkPhysicalDeviceCooperativeMatrixFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCooperativeMatrixFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCooperativeMatrixFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceCooperativeMatrixFeaturesKHR
{
}
