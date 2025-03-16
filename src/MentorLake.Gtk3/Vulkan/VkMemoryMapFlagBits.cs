namespace MentorLake.Vulkan;

public class VkMemoryMapFlagBitsHandle : BaseSafeHandle
{
}


public static class VkMemoryMapFlagBitsExtensions
{

	public static VkMemoryMapFlagBits Dereference(this VkMemoryMapFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryMapFlagBits>(x.DangerousGetHandle());
}
internal class VkMemoryMapFlagBitsExterns
{
}

public struct VkMemoryMapFlagBits
{
}
