namespace MentorLake.Vulkan;


public class VkBufferDeviceAddressInfoHandle : BaseSafeHandle
{
}


public static class VkBufferDeviceAddressInfoExtensions
{

	public static VkBufferDeviceAddressInfo Dereference(this VkBufferDeviceAddressInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferDeviceAddressInfo>(x.DangerousGetHandle());
}
internal class VkBufferDeviceAddressInfoExterns
{
}


public struct VkBufferDeviceAddressInfo
{
}
