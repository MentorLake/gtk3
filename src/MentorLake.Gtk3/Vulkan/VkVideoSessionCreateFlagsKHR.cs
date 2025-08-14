namespace MentorLake.Vulkan;


public class VkVideoSessionCreateFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoSessionCreateFlagsKHRExtensions
{

	public static VkVideoSessionCreateFlagsKHR Dereference(this VkVideoSessionCreateFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoSessionCreateFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoSessionCreateFlagsKHRExterns
{
}


public struct VkVideoSessionCreateFlagsKHR
{
}
