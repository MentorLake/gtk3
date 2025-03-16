namespace MentorLake.Vulkan;

public class VkDeviceAddressBindingTypeEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceAddressBindingTypeEXTExtensions
{

	public static VkDeviceAddressBindingTypeEXT Dereference(this VkDeviceAddressBindingTypeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceAddressBindingTypeEXT>(x.DangerousGetHandle());
}
internal class VkDeviceAddressBindingTypeEXTExterns
{
}

public struct VkDeviceAddressBindingTypeEXT
{
}
