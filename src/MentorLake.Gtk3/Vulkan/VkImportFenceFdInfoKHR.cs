namespace MentorLake.Vulkan;

public class VkImportFenceFdInfoKHRHandle : BaseSafeHandle
{
}


public static class VkImportFenceFdInfoKHRExtensions
{

	public static VkImportFenceFdInfoKHR Dereference(this VkImportFenceFdInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImportFenceFdInfoKHR>(x.DangerousGetHandle());
}
internal class VkImportFenceFdInfoKHRExterns
{
}

public struct VkImportFenceFdInfoKHR
{
}
