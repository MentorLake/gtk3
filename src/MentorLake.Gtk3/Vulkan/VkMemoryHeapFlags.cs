namespace MentorLake.Vulkan;

public class VkMemoryHeapFlagsHandle : BaseSafeHandle
{
}


public static class VkMemoryHeapFlagsExtensions
{

	public static VkMemoryHeapFlags Dereference(this VkMemoryHeapFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryHeapFlags>(x.DangerousGetHandle());
}
internal class VkMemoryHeapFlagsExterns
{
}

public struct VkMemoryHeapFlags
{
}
