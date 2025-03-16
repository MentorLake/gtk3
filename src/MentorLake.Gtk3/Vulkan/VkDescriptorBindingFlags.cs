namespace MentorLake.Vulkan;

public class VkDescriptorBindingFlagsHandle : BaseSafeHandle
{
}


public static class VkDescriptorBindingFlagsExtensions
{

	public static VkDescriptorBindingFlags Dereference(this VkDescriptorBindingFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorBindingFlags>(x.DangerousGetHandle());
}
internal class VkDescriptorBindingFlagsExterns
{
}

public struct VkDescriptorBindingFlags
{
}
