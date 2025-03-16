namespace MentorLake.Vulkan;

public class VkExportSemaphoreCreateInfoHandle : BaseSafeHandle
{
}


public static class VkExportSemaphoreCreateInfoExtensions
{

	public static VkExportSemaphoreCreateInfo Dereference(this VkExportSemaphoreCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExportSemaphoreCreateInfo>(x.DangerousGetHandle());
}
internal class VkExportSemaphoreCreateInfoExterns
{
}

public struct VkExportSemaphoreCreateInfo
{
}
