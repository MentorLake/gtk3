namespace MentorLake.Vulkan;


public class VkDescriptorPoolCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkDescriptorPoolCreateFlagsExtensions
{

	public static VkDescriptorPoolCreateFlags Dereference(this VkDescriptorPoolCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorPoolCreateFlags>(x.DangerousGetHandle());
}
internal class VkDescriptorPoolCreateFlagsExterns
{
}


public struct VkDescriptorPoolCreateFlags
{
}
