namespace MentorLake.Vulkan;

public class VkDescriptorTypeHandle : BaseSafeHandle
{
}


public static class VkDescriptorTypeExtensions
{

	public static VkDescriptorType Dereference(this VkDescriptorTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorType>(x.DangerousGetHandle());
}
internal class VkDescriptorTypeExterns
{
}

public struct VkDescriptorType
{
}
