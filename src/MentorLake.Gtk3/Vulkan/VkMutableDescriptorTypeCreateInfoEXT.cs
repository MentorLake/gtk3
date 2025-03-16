namespace MentorLake.Vulkan;

public class VkMutableDescriptorTypeCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMutableDescriptorTypeCreateInfoEXTExtensions
{

	public static VkMutableDescriptorTypeCreateInfoEXT Dereference(this VkMutableDescriptorTypeCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMutableDescriptorTypeCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkMutableDescriptorTypeCreateInfoEXTExterns
{
}

public struct VkMutableDescriptorTypeCreateInfoEXT
{
}
