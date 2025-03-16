namespace MentorLake.Vulkan;

public class VkDescriptorImageInfoHandle : BaseSafeHandle
{
}


public static class VkDescriptorImageInfoExtensions
{

	public static VkDescriptorImageInfo Dereference(this VkDescriptorImageInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorImageInfo>(x.DangerousGetHandle());
}
internal class VkDescriptorImageInfoExterns
{
}

public struct VkDescriptorImageInfo
{
}
