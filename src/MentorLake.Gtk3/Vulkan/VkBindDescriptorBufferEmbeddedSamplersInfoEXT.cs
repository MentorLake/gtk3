namespace MentorLake.Vulkan;

public class VkBindDescriptorBufferEmbeddedSamplersInfoEXTHandle : BaseSafeHandle
{
}


public static class VkBindDescriptorBufferEmbeddedSamplersInfoEXTExtensions
{

	public static VkBindDescriptorBufferEmbeddedSamplersInfoEXT Dereference(this VkBindDescriptorBufferEmbeddedSamplersInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindDescriptorBufferEmbeddedSamplersInfoEXT>(x.DangerousGetHandle());
}
internal class VkBindDescriptorBufferEmbeddedSamplersInfoEXTExterns
{
}

public struct VkBindDescriptorBufferEmbeddedSamplersInfoEXT
{
}
