namespace MentorLake.Vulkan;

public class VkSparseBufferMemoryBindInfoHandle : BaseSafeHandle
{
}


public static class VkSparseBufferMemoryBindInfoExtensions
{

	public static VkSparseBufferMemoryBindInfo Dereference(this VkSparseBufferMemoryBindInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseBufferMemoryBindInfo>(x.DangerousGetHandle());
}
internal class VkSparseBufferMemoryBindInfoExterns
{
}

public struct VkSparseBufferMemoryBindInfo
{
}
