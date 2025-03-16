namespace MentorLake.Vulkan;

public class VkDebugReportCallbackEXTHandle : BaseSafeHandle
{
}


public static class VkDebugReportCallbackEXTExtensions
{

	public static VkDebugReportCallbackEXT Dereference(this VkDebugReportCallbackEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugReportCallbackEXT>(x.DangerousGetHandle());
}
internal class VkDebugReportCallbackEXTExterns
{
}

public struct VkDebugReportCallbackEXT
{
}
