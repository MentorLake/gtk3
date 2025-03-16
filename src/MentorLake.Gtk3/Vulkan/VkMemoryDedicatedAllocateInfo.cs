namespace MentorLake.Vulkan;

public class VkMemoryDedicatedAllocateInfoHandle : BaseSafeHandle
{
}


public static class VkMemoryDedicatedAllocateInfoExtensions
{

	public static VkMemoryDedicatedAllocateInfo Dereference(this VkMemoryDedicatedAllocateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryDedicatedAllocateInfo>(x.DangerousGetHandle());
}
internal class VkMemoryDedicatedAllocateInfoExterns
{
}

public struct VkMemoryDedicatedAllocateInfo
{
}
