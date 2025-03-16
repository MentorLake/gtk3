namespace MentorLake.Vulkan;

public class VkExportMemoryAllocateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkExportMemoryAllocateInfoKHRExtensions
{

	public static VkExportMemoryAllocateInfoKHR Dereference(this VkExportMemoryAllocateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExportMemoryAllocateInfoKHR>(x.DangerousGetHandle());
}
internal class VkExportMemoryAllocateInfoKHRExterns
{
}

public struct VkExportMemoryAllocateInfoKHR
{
}
