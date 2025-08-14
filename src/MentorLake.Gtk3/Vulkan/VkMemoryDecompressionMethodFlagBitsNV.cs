namespace MentorLake.Vulkan;


public class VkMemoryDecompressionMethodFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkMemoryDecompressionMethodFlagBitsNVExtensions
{

	public static VkMemoryDecompressionMethodFlagBitsNV Dereference(this VkMemoryDecompressionMethodFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryDecompressionMethodFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkMemoryDecompressionMethodFlagBitsNVExterns
{
}


public struct VkMemoryDecompressionMethodFlagBitsNV
{
}
