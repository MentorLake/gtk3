namespace MentorLake.Vulkan;


public class VkSubpassDescriptionDepthStencilResolveKHRHandle : BaseSafeHandle
{
}


public static class VkSubpassDescriptionDepthStencilResolveKHRExtensions
{

	public static VkSubpassDescriptionDepthStencilResolveKHR Dereference(this VkSubpassDescriptionDepthStencilResolveKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDescriptionDepthStencilResolveKHR>(x.DangerousGetHandle());
}
internal class VkSubpassDescriptionDepthStencilResolveKHRExterns
{
}


public struct VkSubpassDescriptionDepthStencilResolveKHR
{
}
