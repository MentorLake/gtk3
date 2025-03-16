namespace MentorLake.Vulkan;

public class VkPhysicalDeviceCudaKernelLaunchFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCudaKernelLaunchFeaturesNVExtensions
{

	public static VkPhysicalDeviceCudaKernelLaunchFeaturesNV Dereference(this VkPhysicalDeviceCudaKernelLaunchFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCudaKernelLaunchFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCudaKernelLaunchFeaturesNVExterns
{
}

public struct VkPhysicalDeviceCudaKernelLaunchFeaturesNV
{
}
