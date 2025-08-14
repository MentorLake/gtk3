namespace MentorLake.Vulkan;


public class VkResolveImageInfo2Handle : BaseSafeHandle
{
}


public static class VkResolveImageInfo2Extensions
{

	public static VkResolveImageInfo2 Dereference(this VkResolveImageInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkResolveImageInfo2>(x.DangerousGetHandle());
}
internal class VkResolveImageInfo2Externs
{
}


public struct VkResolveImageInfo2
{
}
