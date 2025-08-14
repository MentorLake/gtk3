namespace MentorLake.Vulkan;


public class VkTraceRaysIndirectCommandKHRHandle : BaseSafeHandle
{
}


public static class VkTraceRaysIndirectCommandKHRExtensions
{

	public static VkTraceRaysIndirectCommandKHR Dereference(this VkTraceRaysIndirectCommandKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTraceRaysIndirectCommandKHR>(x.DangerousGetHandle());
}
internal class VkTraceRaysIndirectCommandKHRExterns
{
}


public struct VkTraceRaysIndirectCommandKHR
{
}
