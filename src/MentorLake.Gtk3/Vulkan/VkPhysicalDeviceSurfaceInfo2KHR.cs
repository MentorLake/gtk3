namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSurfaceInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSurfaceInfo2KHRExtensions
{

	public static VkPhysicalDeviceSurfaceInfo2KHR Dereference(this VkPhysicalDeviceSurfaceInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSurfaceInfo2KHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSurfaceInfo2KHRExterns
{
}

public struct VkPhysicalDeviceSurfaceInfo2KHR
{
}
