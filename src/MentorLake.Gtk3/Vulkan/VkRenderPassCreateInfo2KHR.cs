namespace MentorLake.Vulkan;

public class VkRenderPassCreateInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkRenderPassCreateInfo2KHRExtensions
{

	public static VkRenderPassCreateInfo2KHR Dereference(this VkRenderPassCreateInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassCreateInfo2KHR>(x.DangerousGetHandle());
}
internal class VkRenderPassCreateInfo2KHRExterns
{
}

public struct VkRenderPassCreateInfo2KHR
{
}
