namespace MentorLake.Vulkan;

public class VkPhysicalDeviceFeatures2Handle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFeatures2Extensions
{

	public static VkPhysicalDeviceFeatures2 Dereference(this VkPhysicalDeviceFeatures2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFeatures2>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFeatures2Externs
{
}

public struct VkPhysicalDeviceFeatures2
{
}
