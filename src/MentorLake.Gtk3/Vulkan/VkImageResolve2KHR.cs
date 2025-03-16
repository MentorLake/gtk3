namespace MentorLake.Vulkan;

public class VkImageResolve2KHRHandle : BaseSafeHandle
{
}


public static class VkImageResolve2KHRExtensions
{

	public static VkImageResolve2KHR Dereference(this VkImageResolve2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageResolve2KHR>(x.DangerousGetHandle());
}
internal class VkImageResolve2KHRExterns
{
}

public struct VkImageResolve2KHR
{
}
