namespace MentorLake.Vulkan;


public class VkRenderPassCreateInfo2Handle : BaseSafeHandle
{
}


public static class VkRenderPassCreateInfo2Extensions
{

	public static VkRenderPassCreateInfo2 Dereference(this VkRenderPassCreateInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassCreateInfo2>(x.DangerousGetHandle());
}
internal class VkRenderPassCreateInfo2Externs
{
}


public struct VkRenderPassCreateInfo2
{
}
