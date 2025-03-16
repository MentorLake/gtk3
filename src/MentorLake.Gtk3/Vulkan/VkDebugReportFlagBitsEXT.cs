namespace MentorLake.Vulkan;

public class VkDebugReportFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkDebugReportFlagBitsEXTExtensions
{

	public static VkDebugReportFlagBitsEXT Dereference(this VkDebugReportFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugReportFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkDebugReportFlagBitsEXTExterns
{
}

public struct VkDebugReportFlagBitsEXT
{
}
