namespace MentorLake.Vulkan;

public class VkMemoryAllocateFlagsInfoHandle : BaseSafeHandle
{
}


public static class VkMemoryAllocateFlagsInfoExtensions
{

	public static VkMemoryAllocateFlagsInfo Dereference(this VkMemoryAllocateFlagsInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryAllocateFlagsInfo>(x.DangerousGetHandle());
}
internal class VkMemoryAllocateFlagsInfoExterns
{
}

public struct VkMemoryAllocateFlagsInfo
{
}
