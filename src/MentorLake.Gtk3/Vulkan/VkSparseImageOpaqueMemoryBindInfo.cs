namespace MentorLake.Vulkan;


public class VkSparseImageOpaqueMemoryBindInfoHandle : BaseSafeHandle
{
}


public static class VkSparseImageOpaqueMemoryBindInfoExtensions
{

	public static VkSparseImageOpaqueMemoryBindInfo Dereference(this VkSparseImageOpaqueMemoryBindInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageOpaqueMemoryBindInfo>(x.DangerousGetHandle());
}
internal class VkSparseImageOpaqueMemoryBindInfoExterns
{
}


public struct VkSparseImageOpaqueMemoryBindInfo
{
}
