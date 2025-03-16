namespace MentorLake.Vulkan;

public class VkDescriptorPoolResetFlagsHandle : BaseSafeHandle
{
}


public static class VkDescriptorPoolResetFlagsExtensions
{

	public static VkDescriptorPoolResetFlags Dereference(this VkDescriptorPoolResetFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorPoolResetFlags>(x.DangerousGetHandle());
}
internal class VkDescriptorPoolResetFlagsExterns
{
}

public struct VkDescriptorPoolResetFlags
{
}
