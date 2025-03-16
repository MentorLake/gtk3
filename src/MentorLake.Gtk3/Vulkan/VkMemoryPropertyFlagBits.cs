namespace MentorLake.Vulkan;

public class VkMemoryPropertyFlagBitsHandle : BaseSafeHandle
{
}


public static class VkMemoryPropertyFlagBitsExtensions
{

	public static VkMemoryPropertyFlagBits Dereference(this VkMemoryPropertyFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryPropertyFlagBits>(x.DangerousGetHandle());
}
internal class VkMemoryPropertyFlagBitsExterns
{
}

public struct VkMemoryPropertyFlagBits
{
}
