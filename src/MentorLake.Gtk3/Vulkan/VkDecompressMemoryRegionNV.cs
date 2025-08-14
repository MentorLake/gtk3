namespace MentorLake.Vulkan;


public class VkDecompressMemoryRegionNVHandle : BaseSafeHandle
{
}


public static class VkDecompressMemoryRegionNVExtensions
{

	public static VkDecompressMemoryRegionNV Dereference(this VkDecompressMemoryRegionNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDecompressMemoryRegionNV>(x.DangerousGetHandle());
}
internal class VkDecompressMemoryRegionNVExterns
{
}


public struct VkDecompressMemoryRegionNV
{
}
