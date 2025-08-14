namespace MentorLake.Vulkan;


public class VkStencilOpStateHandle : BaseSafeHandle
{
}


public static class VkStencilOpStateExtensions
{

	public static VkStencilOpState Dereference(this VkStencilOpStateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkStencilOpState>(x.DangerousGetHandle());
}
internal class VkStencilOpStateExterns
{
}


public struct VkStencilOpState
{
}
