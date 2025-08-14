namespace MentorLake.Vulkan;


public class VkDebugReportFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkDebugReportFlagsEXTExtensions
{

	public static VkDebugReportFlagsEXT Dereference(this VkDebugReportFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugReportFlagsEXT>(x.DangerousGetHandle());
}
internal class VkDebugReportFlagsEXTExterns
{
}


public struct VkDebugReportFlagsEXT
{
}
