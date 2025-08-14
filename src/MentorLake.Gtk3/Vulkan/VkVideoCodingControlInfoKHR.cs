namespace MentorLake.Vulkan;


public class VkVideoCodingControlInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoCodingControlInfoKHRExtensions
{

	public static VkVideoCodingControlInfoKHR Dereference(this VkVideoCodingControlInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoCodingControlInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoCodingControlInfoKHRExterns
{
}


public struct VkVideoCodingControlInfoKHR
{
}
