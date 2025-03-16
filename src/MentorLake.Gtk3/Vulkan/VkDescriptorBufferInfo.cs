namespace MentorLake.Vulkan;

public class VkDescriptorBufferInfoHandle : BaseSafeHandle
{
}


public static class VkDescriptorBufferInfoExtensions
{

	public static VkDescriptorBufferInfo Dereference(this VkDescriptorBufferInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorBufferInfo>(x.DangerousGetHandle());
}
internal class VkDescriptorBufferInfoExterns
{
}

public struct VkDescriptorBufferInfo
{
}
