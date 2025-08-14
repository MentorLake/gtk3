namespace MentorLake.Vulkan;


public class VkPhysicalDeviceCudaKernelLaunchPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCudaKernelLaunchPropertiesNVExtensions
{

	public static VkPhysicalDeviceCudaKernelLaunchPropertiesNV Dereference(this VkPhysicalDeviceCudaKernelLaunchPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCudaKernelLaunchPropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCudaKernelLaunchPropertiesNVExterns
{
}


public struct VkPhysicalDeviceCudaKernelLaunchPropertiesNV
{
}
