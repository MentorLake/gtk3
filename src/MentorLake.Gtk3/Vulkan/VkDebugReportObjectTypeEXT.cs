namespace MentorLake.Vulkan;


public class VkDebugReportObjectTypeEXTHandle : BaseSafeHandle
{
}


public static class VkDebugReportObjectTypeEXTExtensions
{

	public static VkDebugReportObjectTypeEXT Dereference(this VkDebugReportObjectTypeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugReportObjectTypeEXT>(x.DangerousGetHandle());
}
internal class VkDebugReportObjectTypeEXTExterns
{
}


public struct VkDebugReportObjectTypeEXT
{
}
