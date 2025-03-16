namespace MentorLake.Vulkan;

public class VkImportMemoryFdInfoKHRHandle : BaseSafeHandle
{
}


public static class VkImportMemoryFdInfoKHRExtensions
{

	public static VkImportMemoryFdInfoKHR Dereference(this VkImportMemoryFdInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImportMemoryFdInfoKHR>(x.DangerousGetHandle());
}
internal class VkImportMemoryFdInfoKHRExterns
{
}

public struct VkImportMemoryFdInfoKHR
{
}
