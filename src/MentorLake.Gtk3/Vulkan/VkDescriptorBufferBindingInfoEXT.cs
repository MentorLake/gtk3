namespace MentorLake.Vulkan;


public class VkDescriptorBufferBindingInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorBufferBindingInfoEXTExtensions
{

	public static VkDescriptorBufferBindingInfoEXT Dereference(this VkDescriptorBufferBindingInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorBufferBindingInfoEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorBufferBindingInfoEXTExterns
{
}


public struct VkDescriptorBufferBindingInfoEXT
{
}
