namespace MentorLake.Vulkan;


public class VkDescriptorPoolCreateInfoHandle : BaseSafeHandle
{
}


public static class VkDescriptorPoolCreateInfoExtensions
{

	public static VkDescriptorPoolCreateInfo Dereference(this VkDescriptorPoolCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorPoolCreateInfo>(x.DangerousGetHandle());
}
internal class VkDescriptorPoolCreateInfoExterns
{
}


public struct VkDescriptorPoolCreateInfo
{
}
