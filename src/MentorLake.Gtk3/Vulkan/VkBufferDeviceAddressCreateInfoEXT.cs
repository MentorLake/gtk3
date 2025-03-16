namespace MentorLake.Vulkan;

public class VkBufferDeviceAddressCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkBufferDeviceAddressCreateInfoEXTExtensions
{

	public static VkBufferDeviceAddressCreateInfoEXT Dereference(this VkBufferDeviceAddressCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferDeviceAddressCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkBufferDeviceAddressCreateInfoEXTExterns
{
}

public struct VkBufferDeviceAddressCreateInfoEXT
{
}
