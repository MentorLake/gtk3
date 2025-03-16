namespace MentorLake.Vulkan;

public class VkDeviceAddressBindingCallbackDataEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceAddressBindingCallbackDataEXTExtensions
{

	public static VkDeviceAddressBindingCallbackDataEXT Dereference(this VkDeviceAddressBindingCallbackDataEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceAddressBindingCallbackDataEXT>(x.DangerousGetHandle());
}
internal class VkDeviceAddressBindingCallbackDataEXTExterns
{
}

public struct VkDeviceAddressBindingCallbackDataEXT
{
}
