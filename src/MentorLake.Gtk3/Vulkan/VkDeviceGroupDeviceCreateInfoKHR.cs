namespace MentorLake.Vulkan;


public class VkDeviceGroupDeviceCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupDeviceCreateInfoKHRExtensions
{

	public static VkDeviceGroupDeviceCreateInfoKHR Dereference(this VkDeviceGroupDeviceCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupDeviceCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupDeviceCreateInfoKHRExterns
{
}


public struct VkDeviceGroupDeviceCreateInfoKHR
{
}
