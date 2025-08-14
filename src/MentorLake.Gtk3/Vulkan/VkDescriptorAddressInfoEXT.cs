namespace MentorLake.Vulkan;


public class VkDescriptorAddressInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorAddressInfoEXTExtensions
{

	public static VkDescriptorAddressInfoEXT Dereference(this VkDescriptorAddressInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorAddressInfoEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorAddressInfoEXTExterns
{
}


public struct VkDescriptorAddressInfoEXT
{
}
