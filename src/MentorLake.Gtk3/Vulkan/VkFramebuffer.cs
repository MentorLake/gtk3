namespace MentorLake.Vulkan;

public class VkFramebufferHandle : BaseSafeHandle
{
}


public static class VkFramebufferExtensions
{

	public static VkFramebuffer Dereference(this VkFramebufferHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFramebuffer>(x.DangerousGetHandle());
}
internal class VkFramebufferExterns
{
}

public struct VkFramebuffer
{
}
