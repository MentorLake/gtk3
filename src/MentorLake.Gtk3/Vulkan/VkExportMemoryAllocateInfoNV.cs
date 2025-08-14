namespace MentorLake.Vulkan;


public class VkExportMemoryAllocateInfoNVHandle : BaseSafeHandle
{
}


public static class VkExportMemoryAllocateInfoNVExtensions
{

	public static VkExportMemoryAllocateInfoNV Dereference(this VkExportMemoryAllocateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExportMemoryAllocateInfoNV>(x.DangerousGetHandle());
}
internal class VkExportMemoryAllocateInfoNVExterns
{
}


public struct VkExportMemoryAllocateInfoNV
{
}
