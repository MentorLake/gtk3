namespace MentorLake.Vulkan;


public class VkCopyImageInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkCopyImageInfo2KHRExtensions
{

	public static VkCopyImageInfo2KHR Dereference(this VkCopyImageInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyImageInfo2KHR>(x.DangerousGetHandle());
}
internal class VkCopyImageInfo2KHRExterns
{
}


public struct VkCopyImageInfo2KHR
{
}
