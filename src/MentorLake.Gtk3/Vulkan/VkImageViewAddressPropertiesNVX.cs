namespace MentorLake.Vulkan;


public class VkImageViewAddressPropertiesNVXHandle : BaseSafeHandle
{
}


public static class VkImageViewAddressPropertiesNVXExtensions
{

	public static VkImageViewAddressPropertiesNVX Dereference(this VkImageViewAddressPropertiesNVXHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewAddressPropertiesNVX>(x.DangerousGetHandle());
}
internal class VkImageViewAddressPropertiesNVXExterns
{
}


public struct VkImageViewAddressPropertiesNVX
{
}
