namespace MentorLake.Vulkan;

public class VkImageResolve2Handle : BaseSafeHandle
{
}


public static class VkImageResolve2Extensions
{

	public static VkImageResolve2 Dereference(this VkImageResolve2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageResolve2>(x.DangerousGetHandle());
}
internal class VkImageResolve2Externs
{
}

public struct VkImageResolve2
{
}
