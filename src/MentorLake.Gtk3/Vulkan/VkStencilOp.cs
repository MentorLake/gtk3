namespace MentorLake.Vulkan;

public class VkStencilOpHandle : BaseSafeHandle
{
}


public static class VkStencilOpExtensions
{

	public static VkStencilOp Dereference(this VkStencilOpHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkStencilOp>(x.DangerousGetHandle());
}
internal class VkStencilOpExterns
{
}

public struct VkStencilOp
{
}
