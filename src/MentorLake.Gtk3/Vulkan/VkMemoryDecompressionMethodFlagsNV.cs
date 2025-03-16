namespace MentorLake.Vulkan;

public class VkMemoryDecompressionMethodFlagsNVHandle : BaseSafeHandle
{
}


public static class VkMemoryDecompressionMethodFlagsNVExtensions
{

	public static VkMemoryDecompressionMethodFlagsNV Dereference(this VkMemoryDecompressionMethodFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryDecompressionMethodFlagsNV>(x.DangerousGetHandle());
}
internal class VkMemoryDecompressionMethodFlagsNVExterns
{
}

public struct VkMemoryDecompressionMethodFlagsNV
{
}
