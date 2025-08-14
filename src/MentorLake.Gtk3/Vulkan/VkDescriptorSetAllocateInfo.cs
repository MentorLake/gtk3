namespace MentorLake.Vulkan;


public class VkDescriptorSetAllocateInfoHandle : BaseSafeHandle
{
}


public static class VkDescriptorSetAllocateInfoExtensions
{

	public static VkDescriptorSetAllocateInfo Dereference(this VkDescriptorSetAllocateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorSetAllocateInfo>(x.DangerousGetHandle());
}
internal class VkDescriptorSetAllocateInfoExterns
{
}


public struct VkDescriptorSetAllocateInfo
{
}
