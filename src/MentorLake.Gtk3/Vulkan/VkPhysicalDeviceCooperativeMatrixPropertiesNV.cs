namespace MentorLake.Vulkan;


public class VkPhysicalDeviceCooperativeMatrixPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCooperativeMatrixPropertiesNVExtensions
{

	public static VkPhysicalDeviceCooperativeMatrixPropertiesNV Dereference(this VkPhysicalDeviceCooperativeMatrixPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCooperativeMatrixPropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCooperativeMatrixPropertiesNVExterns
{
}


public struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
{
}
