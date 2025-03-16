namespace MentorLake.Vulkan;

public class VkMemoryMapFlagsHandle : BaseSafeHandle
{
}


public static class VkMemoryMapFlagsExtensions
{

	public static VkMemoryMapFlags Dereference(this VkMemoryMapFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryMapFlags>(x.DangerousGetHandle());
}
internal class VkMemoryMapFlagsExterns
{
}

public struct VkMemoryMapFlags
{
}
