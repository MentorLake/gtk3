namespace MentorLake.Vulkan;


public class VkDeviceOrHostAddressKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceOrHostAddressKHRExtensions
{

	public static VkDeviceOrHostAddressKHR Dereference(this VkDeviceOrHostAddressKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceOrHostAddressKHR>(x.DangerousGetHandle());
}
internal class VkDeviceOrHostAddressKHRExterns
{
}


public struct VkDeviceOrHostAddressKHR
{
}
