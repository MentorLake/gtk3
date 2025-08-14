namespace MentorLake.Vulkan;


public class VkVideoCodingControlFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoCodingControlFlagBitsKHRExtensions
{

	public static VkVideoCodingControlFlagBitsKHR Dereference(this VkVideoCodingControlFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoCodingControlFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoCodingControlFlagBitsKHRExterns
{
}


public struct VkVideoCodingControlFlagBitsKHR
{
}
