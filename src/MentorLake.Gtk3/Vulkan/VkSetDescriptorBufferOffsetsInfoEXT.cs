namespace MentorLake.Vulkan;

public class VkSetDescriptorBufferOffsetsInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSetDescriptorBufferOffsetsInfoEXTExtensions
{

	public static VkSetDescriptorBufferOffsetsInfoEXT Dereference(this VkSetDescriptorBufferOffsetsInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSetDescriptorBufferOffsetsInfoEXT>(x.DangerousGetHandle());
}
internal class VkSetDescriptorBufferOffsetsInfoEXTExterns
{
}

public struct VkSetDescriptorBufferOffsetsInfoEXT
{
}
