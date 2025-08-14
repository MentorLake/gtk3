namespace MentorLake.Vulkan;


public class VkSparseImageMemoryBindInfoHandle : BaseSafeHandle
{
}


public static class VkSparseImageMemoryBindInfoExtensions
{

	public static VkSparseImageMemoryBindInfo Dereference(this VkSparseImageMemoryBindInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageMemoryBindInfo>(x.DangerousGetHandle());
}
internal class VkSparseImageMemoryBindInfoExterns
{
}


public struct VkSparseImageMemoryBindInfo
{
}
