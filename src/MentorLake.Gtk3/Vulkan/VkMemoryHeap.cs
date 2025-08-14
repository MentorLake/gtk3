namespace MentorLake.Vulkan;


public class VkMemoryHeapHandle : BaseSafeHandle
{
}


public static class VkMemoryHeapExtensions
{

	public static VkMemoryHeap Dereference(this VkMemoryHeapHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryHeap>(x.DangerousGetHandle());
}
internal class VkMemoryHeapExterns
{
}


public struct VkMemoryHeap
{
}
