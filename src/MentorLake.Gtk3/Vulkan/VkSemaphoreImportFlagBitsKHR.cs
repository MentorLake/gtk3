namespace MentorLake.Vulkan;


public class VkSemaphoreImportFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreImportFlagBitsKHRExtensions
{

	public static VkSemaphoreImportFlagBitsKHR Dereference(this VkSemaphoreImportFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreImportFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreImportFlagBitsKHRExterns
{
}


public struct VkSemaphoreImportFlagBitsKHR
{
}
