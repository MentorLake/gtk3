namespace MentorLake.Vulkan;

public class VkCopyImageInfo2Handle : BaseSafeHandle
{
}


public static class VkCopyImageInfo2Extensions
{

	public static VkCopyImageInfo2 Dereference(this VkCopyImageInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyImageInfo2>(x.DangerousGetHandle());
}
internal class VkCopyImageInfo2Externs
{
}

public struct VkCopyImageInfo2
{
}
