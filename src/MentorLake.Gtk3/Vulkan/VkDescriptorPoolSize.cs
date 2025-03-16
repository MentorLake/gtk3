namespace MentorLake.Vulkan;

public class VkDescriptorPoolSizeHandle : BaseSafeHandle
{
}


public static class VkDescriptorPoolSizeExtensions
{

	public static VkDescriptorPoolSize Dereference(this VkDescriptorPoolSizeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorPoolSize>(x.DangerousGetHandle());
}
internal class VkDescriptorPoolSizeExterns
{
}

public struct VkDescriptorPoolSize
{
}
