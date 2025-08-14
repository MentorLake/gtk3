namespace MentorLake.Vulkan;


public class VkImageViewCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkImageViewCreateFlagsExtensions
{

	public static VkImageViewCreateFlags Dereference(this VkImageViewCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewCreateFlags>(x.DangerousGetHandle());
}
internal class VkImageViewCreateFlagsExterns
{
}


public struct VkImageViewCreateFlags
{
}
