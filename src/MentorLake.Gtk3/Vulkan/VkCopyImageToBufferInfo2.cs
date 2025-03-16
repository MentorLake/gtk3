namespace MentorLake.Vulkan;

public class VkCopyImageToBufferInfo2Handle : BaseSafeHandle
{
}


public static class VkCopyImageToBufferInfo2Extensions
{

	public static VkCopyImageToBufferInfo2 Dereference(this VkCopyImageToBufferInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyImageToBufferInfo2>(x.DangerousGetHandle());
}
internal class VkCopyImageToBufferInfo2Externs
{
}

public struct VkCopyImageToBufferInfo2
{
}
