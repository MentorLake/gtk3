namespace MentorLake.Vulkan;

public class VkDeviceMemoryOpaqueCaptureAddressInfoHandle : BaseSafeHandle
{
}


public static class VkDeviceMemoryOpaqueCaptureAddressInfoExtensions
{

	public static VkDeviceMemoryOpaqueCaptureAddressInfo Dereference(this VkDeviceMemoryOpaqueCaptureAddressInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceMemoryOpaqueCaptureAddressInfo>(x.DangerousGetHandle());
}
internal class VkDeviceMemoryOpaqueCaptureAddressInfoExterns
{
}

public struct VkDeviceMemoryOpaqueCaptureAddressInfo
{
}
