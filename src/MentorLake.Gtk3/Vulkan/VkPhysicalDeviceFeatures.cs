namespace MentorLake.Vulkan;


public class VkPhysicalDeviceFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFeaturesExtensions
{

	public static VkPhysicalDeviceFeatures Dereference(this VkPhysicalDeviceFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFeaturesExterns
{
}


public struct VkPhysicalDeviceFeatures
{
}
