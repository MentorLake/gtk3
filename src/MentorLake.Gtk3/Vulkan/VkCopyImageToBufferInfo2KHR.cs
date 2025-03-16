namespace MentorLake.Vulkan;

public class VkCopyImageToBufferInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkCopyImageToBufferInfo2KHRExtensions
{

	public static VkCopyImageToBufferInfo2KHR Dereference(this VkCopyImageToBufferInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyImageToBufferInfo2KHR>(x.DangerousGetHandle());
}
internal class VkCopyImageToBufferInfo2KHRExterns
{
}

public struct VkCopyImageToBufferInfo2KHR
{
}
