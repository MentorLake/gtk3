namespace MentorLake.Vulkan;

public class VkSemaphoreImportFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreImportFlagsKHRExtensions
{

	public static VkSemaphoreImportFlagsKHR Dereference(this VkSemaphoreImportFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreImportFlagsKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreImportFlagsKHRExterns
{
}

public struct VkSemaphoreImportFlagsKHR
{
}
