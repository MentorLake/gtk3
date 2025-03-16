namespace MentorLake.Vulkan;

public class VkBufferOpaqueCaptureAddressCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBufferOpaqueCaptureAddressCreateInfoKHRExtensions
{

	public static VkBufferOpaqueCaptureAddressCreateInfoKHR Dereference(this VkBufferOpaqueCaptureAddressCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferOpaqueCaptureAddressCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkBufferOpaqueCaptureAddressCreateInfoKHRExterns
{
}

public struct VkBufferOpaqueCaptureAddressCreateInfoKHR
{
}
