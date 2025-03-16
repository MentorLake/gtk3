namespace MentorLake.Vulkan;

public class VkVideoCodingControlFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoCodingControlFlagsKHRExtensions
{

	public static VkVideoCodingControlFlagsKHR Dereference(this VkVideoCodingControlFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoCodingControlFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoCodingControlFlagsKHRExterns
{
}

public struct VkVideoCodingControlFlagsKHR
{
}
