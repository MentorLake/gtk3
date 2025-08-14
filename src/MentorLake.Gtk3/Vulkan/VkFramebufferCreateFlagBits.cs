namespace MentorLake.Vulkan;


public class VkFramebufferCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkFramebufferCreateFlagBitsExtensions
{

	public static VkFramebufferCreateFlagBits Dereference(this VkFramebufferCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFramebufferCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkFramebufferCreateFlagBitsExterns
{
}


public struct VkFramebufferCreateFlagBits
{
}
