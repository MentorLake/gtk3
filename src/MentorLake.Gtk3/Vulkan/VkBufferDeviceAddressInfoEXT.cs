namespace MentorLake.Vulkan;


public class VkBufferDeviceAddressInfoEXTHandle : BaseSafeHandle
{
}


public static class VkBufferDeviceAddressInfoEXTExtensions
{

	public static VkBufferDeviceAddressInfoEXT Dereference(this VkBufferDeviceAddressInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferDeviceAddressInfoEXT>(x.DangerousGetHandle());
}
internal class VkBufferDeviceAddressInfoEXTExterns
{
}


public struct VkBufferDeviceAddressInfoEXT
{
}
