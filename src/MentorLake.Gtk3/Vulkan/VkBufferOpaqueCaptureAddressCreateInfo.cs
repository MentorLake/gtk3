namespace MentorLake.Vulkan;


public class VkBufferOpaqueCaptureAddressCreateInfoHandle : BaseSafeHandle
{
}


public static class VkBufferOpaqueCaptureAddressCreateInfoExtensions
{

	public static VkBufferOpaqueCaptureAddressCreateInfo Dereference(this VkBufferOpaqueCaptureAddressCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferOpaqueCaptureAddressCreateInfo>(x.DangerousGetHandle());
}
internal class VkBufferOpaqueCaptureAddressCreateInfoExterns
{
}


public struct VkBufferOpaqueCaptureAddressCreateInfo
{
}
