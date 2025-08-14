namespace MentorLake.Vulkan;


public class VkCommandBufferInheritanceRenderingInfoKHRHandle : BaseSafeHandle
{
}


public static class VkCommandBufferInheritanceRenderingInfoKHRExtensions
{

	public static VkCommandBufferInheritanceRenderingInfoKHR Dereference(this VkCommandBufferInheritanceRenderingInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferInheritanceRenderingInfoKHR>(x.DangerousGetHandle());
}
internal class VkCommandBufferInheritanceRenderingInfoKHRExterns
{
}


public struct VkCommandBufferInheritanceRenderingInfoKHR
{
}
