namespace MentorLake.Vulkan;

public class VkFramebufferCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkFramebufferCreateFlagsExtensions
{

	public static VkFramebufferCreateFlags Dereference(this VkFramebufferCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFramebufferCreateFlags>(x.DangerousGetHandle());
}
internal class VkFramebufferCreateFlagsExterns
{
}

public struct VkFramebufferCreateFlags
{
}
