namespace MentorLake.Vulkan;

public class VkDescriptorBindingFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorBindingFlagBitsEXTExtensions
{

	public static VkDescriptorBindingFlagBitsEXT Dereference(this VkDescriptorBindingFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorBindingFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorBindingFlagBitsEXTExterns
{
}

public struct VkDescriptorBindingFlagBitsEXT
{
}
