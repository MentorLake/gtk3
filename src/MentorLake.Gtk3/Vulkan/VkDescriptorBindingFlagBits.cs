namespace MentorLake.Vulkan;


public class VkDescriptorBindingFlagBitsHandle : BaseSafeHandle
{
}


public static class VkDescriptorBindingFlagBitsExtensions
{

	public static VkDescriptorBindingFlagBits Dereference(this VkDescriptorBindingFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorBindingFlagBits>(x.DangerousGetHandle());
}
internal class VkDescriptorBindingFlagBitsExterns
{
}


public struct VkDescriptorBindingFlagBits
{
}
