namespace MentorLake.Vulkan;

public class VkCopyBufferToImageInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkCopyBufferToImageInfo2KHRExtensions
{

	public static VkCopyBufferToImageInfo2KHR Dereference(this VkCopyBufferToImageInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyBufferToImageInfo2KHR>(x.DangerousGetHandle());
}
internal class VkCopyBufferToImageInfo2KHRExterns
{
}

public struct VkCopyBufferToImageInfo2KHR
{
}
