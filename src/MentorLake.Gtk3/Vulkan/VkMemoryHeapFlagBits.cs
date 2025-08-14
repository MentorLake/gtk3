namespace MentorLake.Vulkan;


public class VkMemoryHeapFlagBitsHandle : BaseSafeHandle
{
}


public static class VkMemoryHeapFlagBitsExtensions
{

	public static VkMemoryHeapFlagBits Dereference(this VkMemoryHeapFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryHeapFlagBits>(x.DangerousGetHandle());
}
internal class VkMemoryHeapFlagBitsExterns
{
}


public struct VkMemoryHeapFlagBits
{
}
