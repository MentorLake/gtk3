namespace MentorLake.Vulkan;

public class VkRenderPassTransformBeginInfoQCOMHandle : BaseSafeHandle
{
}


public static class VkRenderPassTransformBeginInfoQCOMExtensions
{

	public static VkRenderPassTransformBeginInfoQCOM Dereference(this VkRenderPassTransformBeginInfoQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassTransformBeginInfoQCOM>(x.DangerousGetHandle());
}
internal class VkRenderPassTransformBeginInfoQCOMExterns
{
}

public struct VkRenderPassTransformBeginInfoQCOM
{
}
