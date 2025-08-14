namespace MentorLake.Vulkan;


public class VkFramebufferCreateInfoHandle : BaseSafeHandle
{
}


public static class VkFramebufferCreateInfoExtensions
{

	public static VkFramebufferCreateInfo Dereference(this VkFramebufferCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFramebufferCreateInfo>(x.DangerousGetHandle());
}
internal class VkFramebufferCreateInfoExterns
{
}


public struct VkFramebufferCreateInfo
{
}
