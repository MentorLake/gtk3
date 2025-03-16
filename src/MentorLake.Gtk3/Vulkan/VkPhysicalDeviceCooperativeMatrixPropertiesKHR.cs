namespace MentorLake.Vulkan;

public class VkPhysicalDeviceCooperativeMatrixPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCooperativeMatrixPropertiesKHRExtensions
{

	public static VkPhysicalDeviceCooperativeMatrixPropertiesKHR Dereference(this VkPhysicalDeviceCooperativeMatrixPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCooperativeMatrixPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCooperativeMatrixPropertiesKHRExterns
{
}

public struct VkPhysicalDeviceCooperativeMatrixPropertiesKHR
{
}
