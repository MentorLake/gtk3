namespace MentorLake.Vulkan;


public class VkMemoryPropertyFlagsHandle : BaseSafeHandle
{
}


public static class VkMemoryPropertyFlagsExtensions
{

	public static VkMemoryPropertyFlags Dereference(this VkMemoryPropertyFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryPropertyFlags>(x.DangerousGetHandle());
}
internal class VkMemoryPropertyFlagsExterns
{
}


public struct VkMemoryPropertyFlags
{
}
