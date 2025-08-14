namespace MentorLake.Vulkan;


public class VkMemoryTypeHandle : BaseSafeHandle
{
}


public static class VkMemoryTypeExtensions
{

	public static VkMemoryType Dereference(this VkMemoryTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryType>(x.DangerousGetHandle());
}
internal class VkMemoryTypeExterns
{
}


public struct VkMemoryType
{
}
