namespace MentorLake.Vulkan;

public class VkClearDepthStencilValueHandle : BaseSafeHandle
{
}


public static class VkClearDepthStencilValueExtensions
{

	public static VkClearDepthStencilValue Dereference(this VkClearDepthStencilValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkClearDepthStencilValue>(x.DangerousGetHandle());
}
internal class VkClearDepthStencilValueExterns
{
}

public struct VkClearDepthStencilValue
{
}
