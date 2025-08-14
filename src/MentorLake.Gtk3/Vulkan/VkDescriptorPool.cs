namespace MentorLake.Vulkan;


public class VkDescriptorPoolHandle : BaseSafeHandle
{
}


public static class VkDescriptorPoolExtensions
{

	public static VkDescriptorPool Dereference(this VkDescriptorPoolHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorPool>(x.DangerousGetHandle());
}
internal class VkDescriptorPoolExterns
{
}


public struct VkDescriptorPool
{
}
