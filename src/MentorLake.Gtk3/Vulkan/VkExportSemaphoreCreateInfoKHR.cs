namespace MentorLake.Vulkan;

public class VkExportSemaphoreCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkExportSemaphoreCreateInfoKHRExtensions
{

	public static VkExportSemaphoreCreateInfoKHR Dereference(this VkExportSemaphoreCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExportSemaphoreCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkExportSemaphoreCreateInfoKHRExterns
{
}

public struct VkExportSemaphoreCreateInfoKHR
{
}
