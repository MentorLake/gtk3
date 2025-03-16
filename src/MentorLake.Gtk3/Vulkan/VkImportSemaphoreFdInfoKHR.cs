namespace MentorLake.Vulkan;

public class VkImportSemaphoreFdInfoKHRHandle : BaseSafeHandle
{
}


public static class VkImportSemaphoreFdInfoKHRExtensions
{

	public static VkImportSemaphoreFdInfoKHR Dereference(this VkImportSemaphoreFdInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImportSemaphoreFdInfoKHR>(x.DangerousGetHandle());
}
internal class VkImportSemaphoreFdInfoKHRExterns
{
}

public struct VkImportSemaphoreFdInfoKHR
{
}
