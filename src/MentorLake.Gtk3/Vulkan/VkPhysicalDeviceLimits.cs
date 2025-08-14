namespace MentorLake.Vulkan;


public class VkPhysicalDeviceLimitsHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLimitsExtensions
{

	public static VkPhysicalDeviceLimits Dereference(this VkPhysicalDeviceLimitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLimits>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLimitsExterns
{
}


public struct VkPhysicalDeviceLimits
{
}
