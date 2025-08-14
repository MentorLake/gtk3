namespace MentorLake.Vulkan;


public class VkResolveImageInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkResolveImageInfo2KHRExtensions
{

	public static VkResolveImageInfo2KHR Dereference(this VkResolveImageInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkResolveImageInfo2KHR>(x.DangerousGetHandle());
}
internal class VkResolveImageInfo2KHRExterns
{
}


public struct VkResolveImageInfo2KHR
{
}
