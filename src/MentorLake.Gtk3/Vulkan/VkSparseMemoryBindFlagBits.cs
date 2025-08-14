namespace MentorLake.Vulkan;


public class VkSparseMemoryBindFlagBitsHandle : BaseSafeHandle
{
}


public static class VkSparseMemoryBindFlagBitsExtensions
{

	public static VkSparseMemoryBindFlagBits Dereference(this VkSparseMemoryBindFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseMemoryBindFlagBits>(x.DangerousGetHandle());
}
internal class VkSparseMemoryBindFlagBitsExterns
{
}


public struct VkSparseMemoryBindFlagBits
{
}
