namespace MentorLake.Vulkan;


public class VkCopyMemoryToImageIndirectCommandNVHandle : BaseSafeHandle
{
}


public static class VkCopyMemoryToImageIndirectCommandNVExtensions
{

	public static VkCopyMemoryToImageIndirectCommandNV Dereference(this VkCopyMemoryToImageIndirectCommandNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyMemoryToImageIndirectCommandNV>(x.DangerousGetHandle());
}
internal class VkCopyMemoryToImageIndirectCommandNVExterns
{
}


public struct VkCopyMemoryToImageIndirectCommandNV
{
}
