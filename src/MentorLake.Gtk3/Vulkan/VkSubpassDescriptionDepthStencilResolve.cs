namespace MentorLake.Vulkan;

public class VkSubpassDescriptionDepthStencilResolveHandle : BaseSafeHandle
{
}


public static class VkSubpassDescriptionDepthStencilResolveExtensions
{

	public static VkSubpassDescriptionDepthStencilResolve Dereference(this VkSubpassDescriptionDepthStencilResolveHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDescriptionDepthStencilResolve>(x.DangerousGetHandle());
}
internal class VkSubpassDescriptionDepthStencilResolveExterns
{
}

public struct VkSubpassDescriptionDepthStencilResolve
{
}
