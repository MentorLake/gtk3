namespace MentorLake.Vulkan;


public class VkImageResolveHandle : BaseSafeHandle
{
}


public static class VkImageResolveExtensions
{

	public static VkImageResolve Dereference(this VkImageResolveHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageResolve>(x.DangerousGetHandle());
}
internal class VkImageResolveExterns
{
}


public struct VkImageResolve
{
}
