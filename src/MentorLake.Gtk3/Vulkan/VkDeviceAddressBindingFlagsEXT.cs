namespace MentorLake.Vulkan;


public class VkDeviceAddressBindingFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceAddressBindingFlagsEXTExtensions
{

	public static VkDeviceAddressBindingFlagsEXT Dereference(this VkDeviceAddressBindingFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceAddressBindingFlagsEXT>(x.DangerousGetHandle());
}
internal class VkDeviceAddressBindingFlagsEXTExterns
{
}


public struct VkDeviceAddressBindingFlagsEXT
{
}
