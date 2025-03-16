namespace MentorLake.Vulkan;

public class VkDeviceAddressBindingFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceAddressBindingFlagBitsEXTExtensions
{

	public static VkDeviceAddressBindingFlagBitsEXT Dereference(this VkDeviceAddressBindingFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceAddressBindingFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkDeviceAddressBindingFlagBitsEXTExterns
{
}

public struct VkDeviceAddressBindingFlagBitsEXT
{
}
