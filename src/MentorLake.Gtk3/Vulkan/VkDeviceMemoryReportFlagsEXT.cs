namespace MentorLake.Vulkan;

public class VkDeviceMemoryReportFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceMemoryReportFlagsEXTExtensions
{

	public static VkDeviceMemoryReportFlagsEXT Dereference(this VkDeviceMemoryReportFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceMemoryReportFlagsEXT>(x.DangerousGetHandle());
}
internal class VkDeviceMemoryReportFlagsEXTExterns
{
}

public struct VkDeviceMemoryReportFlagsEXT
{
}
