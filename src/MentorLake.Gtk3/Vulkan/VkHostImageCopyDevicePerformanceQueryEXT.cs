namespace MentorLake.Vulkan;


public class VkHostImageCopyDevicePerformanceQueryEXTHandle : BaseSafeHandle
{
}


public static class VkHostImageCopyDevicePerformanceQueryEXTExtensions
{

	public static VkHostImageCopyDevicePerformanceQueryEXT Dereference(this VkHostImageCopyDevicePerformanceQueryEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkHostImageCopyDevicePerformanceQueryEXT>(x.DangerousGetHandle());
}
internal class VkHostImageCopyDevicePerformanceQueryEXTExterns
{
}


public struct VkHostImageCopyDevicePerformanceQueryEXT
{
}
