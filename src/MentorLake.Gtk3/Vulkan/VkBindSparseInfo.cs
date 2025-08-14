namespace MentorLake.Vulkan;


public class VkBindSparseInfoHandle : BaseSafeHandle
{
}


public static class VkBindSparseInfoExtensions
{

	public static VkBindSparseInfo Dereference(this VkBindSparseInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindSparseInfo>(x.DangerousGetHandle());
}
internal class VkBindSparseInfoExterns
{
}


public struct VkBindSparseInfo
{
}
