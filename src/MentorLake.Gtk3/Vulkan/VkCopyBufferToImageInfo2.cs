namespace MentorLake.Vulkan;


public class VkCopyBufferToImageInfo2Handle : BaseSafeHandle
{
}


public static class VkCopyBufferToImageInfo2Extensions
{

	public static VkCopyBufferToImageInfo2 Dereference(this VkCopyBufferToImageInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyBufferToImageInfo2>(x.DangerousGetHandle());
}
internal class VkCopyBufferToImageInfo2Externs
{
}


public struct VkCopyBufferToImageInfo2
{
}
