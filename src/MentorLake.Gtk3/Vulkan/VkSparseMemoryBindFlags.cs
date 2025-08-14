namespace MentorLake.Vulkan;


public class VkSparseMemoryBindFlagsHandle : BaseSafeHandle
{
}


public static class VkSparseMemoryBindFlagsExtensions
{

	public static VkSparseMemoryBindFlags Dereference(this VkSparseMemoryBindFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseMemoryBindFlags>(x.DangerousGetHandle());
}
internal class VkSparseMemoryBindFlagsExterns
{
}


public struct VkSparseMemoryBindFlags
{
}
