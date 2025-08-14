namespace MentorLake.Vulkan;


public class VkQueryResultStatusKHRHandle : BaseSafeHandle
{
}


public static class VkQueryResultStatusKHRExtensions
{

	public static VkQueryResultStatusKHR Dereference(this VkQueryResultStatusKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryResultStatusKHR>(x.DangerousGetHandle());
}
internal class VkQueryResultStatusKHRExterns
{
}


public struct VkQueryResultStatusKHR
{
}
