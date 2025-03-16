namespace MentorLake.Vulkan;

public class VkCopyBufferInfo2Handle : BaseSafeHandle
{
}


public static class VkCopyBufferInfo2Extensions
{

	public static VkCopyBufferInfo2 Dereference(this VkCopyBufferInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyBufferInfo2>(x.DangerousGetHandle());
}
internal class VkCopyBufferInfo2Externs
{
}

public struct VkCopyBufferInfo2
{
}
