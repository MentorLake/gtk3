namespace MentorLake.Vulkan;


public class VkRenderPassHandle : BaseSafeHandle
{
}


public static class VkRenderPassExtensions
{

	public static VkRenderPass Dereference(this VkRenderPassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPass>(x.DangerousGetHandle());
}
internal class VkRenderPassExterns
{
}


public struct VkRenderPass
{
}
