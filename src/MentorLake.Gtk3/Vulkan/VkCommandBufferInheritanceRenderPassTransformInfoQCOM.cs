namespace MentorLake.Vulkan;

public class VkCommandBufferInheritanceRenderPassTransformInfoQCOMHandle : BaseSafeHandle
{
}


public static class VkCommandBufferInheritanceRenderPassTransformInfoQCOMExtensions
{

	public static VkCommandBufferInheritanceRenderPassTransformInfoQCOM Dereference(this VkCommandBufferInheritanceRenderPassTransformInfoQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferInheritanceRenderPassTransformInfoQCOM>(x.DangerousGetHandle());
}
internal class VkCommandBufferInheritanceRenderPassTransformInfoQCOMExterns
{
}

public struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
}
