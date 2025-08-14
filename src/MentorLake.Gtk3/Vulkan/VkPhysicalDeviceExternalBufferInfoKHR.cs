namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExternalBufferInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalBufferInfoKHRExtensions
{

	public static VkPhysicalDeviceExternalBufferInfoKHR Dereference(this VkPhysicalDeviceExternalBufferInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalBufferInfoKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalBufferInfoKHRExterns
{
}


public struct VkPhysicalDeviceExternalBufferInfoKHR
{
}
