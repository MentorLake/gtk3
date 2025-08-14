namespace MentorLake.Vulkan;


public class VkSparseImageMemoryBindHandle : BaseSafeHandle
{
}


public static class VkSparseImageMemoryBindExtensions
{

	public static VkSparseImageMemoryBind Dereference(this VkSparseImageMemoryBindHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageMemoryBind>(x.DangerousGetHandle());
}
internal class VkSparseImageMemoryBindExterns
{
}


public struct VkSparseImageMemoryBind
{
}
