namespace MentorLake.Vulkan;

public class VkDeviceMemoryReportEventTypeEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceMemoryReportEventTypeEXTExtensions
{

	public static VkDeviceMemoryReportEventTypeEXT Dereference(this VkDeviceMemoryReportEventTypeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceMemoryReportEventTypeEXT>(x.DangerousGetHandle());
}
internal class VkDeviceMemoryReportEventTypeEXTExterns
{
}

public struct VkDeviceMemoryReportEventTypeEXT
{
}
