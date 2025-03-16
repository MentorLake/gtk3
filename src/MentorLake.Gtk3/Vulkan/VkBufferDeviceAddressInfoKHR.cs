namespace MentorLake.Vulkan;

public class VkBufferDeviceAddressInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBufferDeviceAddressInfoKHRExtensions
{

	public static VkBufferDeviceAddressInfoKHR Dereference(this VkBufferDeviceAddressInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferDeviceAddressInfoKHR>(x.DangerousGetHandle());
}
internal class VkBufferDeviceAddressInfoKHRExterns
{
}

public struct VkBufferDeviceAddressInfoKHR
{
}
