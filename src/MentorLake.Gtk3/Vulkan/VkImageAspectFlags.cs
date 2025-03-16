namespace MentorLake.Vulkan;

public class VkImageAspectFlagsHandle : BaseSafeHandle
{
}


public static class VkImageAspectFlagsExtensions
{

	public static VkImageAspectFlags Dereference(this VkImageAspectFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageAspectFlags>(x.DangerousGetHandle());
}
internal class VkImageAspectFlagsExterns
{
}

public struct VkImageAspectFlags
{
}
