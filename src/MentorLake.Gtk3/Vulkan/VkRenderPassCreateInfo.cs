namespace MentorLake.Vulkan;

public class VkRenderPassCreateInfoHandle : BaseSafeHandle
{
}


public static class VkRenderPassCreateInfoExtensions
{

	public static VkRenderPassCreateInfo Dereference(this VkRenderPassCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassCreateInfo>(x.DangerousGetHandle());
}
internal class VkRenderPassCreateInfoExterns
{
}

public struct VkRenderPassCreateInfo
{
}
