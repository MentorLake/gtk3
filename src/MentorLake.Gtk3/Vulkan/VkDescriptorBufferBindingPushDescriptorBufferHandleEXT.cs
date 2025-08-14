namespace MentorLake.Vulkan;


public class VkDescriptorBufferBindingPushDescriptorBufferHandleEXTHandle : BaseSafeHandle
{
}


public static class VkDescriptorBufferBindingPushDescriptorBufferHandleEXTExtensions
{

	public static VkDescriptorBufferBindingPushDescriptorBufferHandleEXT Dereference(this VkDescriptorBufferBindingPushDescriptorBufferHandleEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorBufferBindingPushDescriptorBufferHandleEXT>(x.DangerousGetHandle());
}
internal class VkDescriptorBufferBindingPushDescriptorBufferHandleEXTExterns
{
}


public struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT
{
}
