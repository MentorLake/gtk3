namespace MentorLake.Vulkan;

public class VkDeviceMemoryReportCallbackDataEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceMemoryReportCallbackDataEXTExtensions
{

	public static VkDeviceMemoryReportCallbackDataEXT Dereference(this VkDeviceMemoryReportCallbackDataEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceMemoryReportCallbackDataEXT>(x.DangerousGetHandle());
}
internal class VkDeviceMemoryReportCallbackDataEXTExterns
{
}

public struct VkDeviceMemoryReportCallbackDataEXT
{
}
