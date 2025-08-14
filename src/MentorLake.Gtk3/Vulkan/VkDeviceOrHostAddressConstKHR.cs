namespace MentorLake.Vulkan;


public class VkDeviceOrHostAddressConstKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceOrHostAddressConstKHRExtensions
{

	public static VkDeviceOrHostAddressConstKHR Dereference(this VkDeviceOrHostAddressConstKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceOrHostAddressConstKHR>(x.DangerousGetHandle());
}
internal class VkDeviceOrHostAddressConstKHRExterns
{
}


public struct VkDeviceOrHostAddressConstKHR
{
}
