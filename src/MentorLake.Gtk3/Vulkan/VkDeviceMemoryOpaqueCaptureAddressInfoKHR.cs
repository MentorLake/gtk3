namespace MentorLake.Vulkan;

public class VkDeviceMemoryOpaqueCaptureAddressInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceMemoryOpaqueCaptureAddressInfoKHRExtensions
{

	public static VkDeviceMemoryOpaqueCaptureAddressInfoKHR Dereference(this VkDeviceMemoryOpaqueCaptureAddressInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceMemoryOpaqueCaptureAddressInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceMemoryOpaqueCaptureAddressInfoKHRExterns
{
}

public struct VkDeviceMemoryOpaqueCaptureAddressInfoKHR
{
}
