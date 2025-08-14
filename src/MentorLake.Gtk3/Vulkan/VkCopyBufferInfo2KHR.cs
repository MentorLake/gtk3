namespace MentorLake.Vulkan;


public class VkCopyBufferInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkCopyBufferInfo2KHRExtensions
{

	public static VkCopyBufferInfo2KHR Dereference(this VkCopyBufferInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyBufferInfo2KHR>(x.DangerousGetHandle());
}
internal class VkCopyBufferInfo2KHRExterns
{
}


public struct VkCopyBufferInfo2KHR
{
}
