namespace MentorLake.Vulkan;


public class VkSparseMemoryBindHandle : BaseSafeHandle
{
}


public static class VkSparseMemoryBindExtensions
{

	public static VkSparseMemoryBind Dereference(this VkSparseMemoryBindHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseMemoryBind>(x.DangerousGetHandle());
}
internal class VkSparseMemoryBindExterns
{
}


public struct VkSparseMemoryBind
{
}
