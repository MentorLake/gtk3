namespace MentorLake.Vulkan;


public class VkSubmitFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkSubmitFlagsKHRExtensions
{

	public static VkSubmitFlagsKHR Dereference(this VkSubmitFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubmitFlagsKHR>(x.DangerousGetHandle());
}
internal class VkSubmitFlagsKHRExterns
{
}


public struct VkSubmitFlagsKHR
{
}
