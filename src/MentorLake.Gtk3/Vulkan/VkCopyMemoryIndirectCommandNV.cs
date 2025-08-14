namespace MentorLake.Vulkan;


public class VkCopyMemoryIndirectCommandNVHandle : BaseSafeHandle
{
}


public static class VkCopyMemoryIndirectCommandNVExtensions
{

	public static VkCopyMemoryIndirectCommandNV Dereference(this VkCopyMemoryIndirectCommandNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyMemoryIndirectCommandNV>(x.DangerousGetHandle());
}
internal class VkCopyMemoryIndirectCommandNVExterns
{
}


public struct VkCopyMemoryIndirectCommandNV
{
}
