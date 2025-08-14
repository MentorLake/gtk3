namespace MentorLake.Vulkan;


public class VkRenderPassCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkRenderPassCreateFlagsExtensions
{

	public static VkRenderPassCreateFlags Dereference(this VkRenderPassCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassCreateFlags>(x.DangerousGetHandle());
}
internal class VkRenderPassCreateFlagsExterns
{
}


public struct VkRenderPassCreateFlags
{
}
