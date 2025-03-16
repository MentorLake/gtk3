namespace MentorLake.Vulkan;

public class VkExportFenceCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkExportFenceCreateInfoKHRExtensions
{

	public static VkExportFenceCreateInfoKHR Dereference(this VkExportFenceCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExportFenceCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkExportFenceCreateInfoKHRExterns
{
}

public struct VkExportFenceCreateInfoKHR
{
}
