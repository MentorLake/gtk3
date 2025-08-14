namespace MentorLake.Vulkan;


public class VkCommandBufferInheritanceConditionalRenderingInfoEXTHandle : BaseSafeHandle
{
}


public static class VkCommandBufferInheritanceConditionalRenderingInfoEXTExtensions
{

	public static VkCommandBufferInheritanceConditionalRenderingInfoEXT Dereference(this VkCommandBufferInheritanceConditionalRenderingInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferInheritanceConditionalRenderingInfoEXT>(x.DangerousGetHandle());
}
internal class VkCommandBufferInheritanceConditionalRenderingInfoEXTExterns
{
}


public struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
{
}
