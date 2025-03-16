namespace MentorLake.Vulkan;

public class VkDescriptorBindingFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorBindingFlagsEXTExtensions
{

	public static VkDescriptorBindingFlagsEXT Dereference(this VkDescriptorBindingFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorBindingFlagsEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorBindingFlagsEXTExterns
{
}

public struct VkDescriptorBindingFlagsEXT
{
}
