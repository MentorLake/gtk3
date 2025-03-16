namespace MentorLake.Vulkan;

public class VkDescriptorPoolCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkDescriptorPoolCreateFlagBitsExtensions
{

	public static VkDescriptorPoolCreateFlagBits Dereference(this VkDescriptorPoolCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDescriptorPoolCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkDescriptorPoolCreateFlagBitsExterns
{
}

public struct VkDescriptorPoolCreateFlagBits
{
}
