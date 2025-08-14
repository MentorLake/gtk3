namespace MentorLake.Vulkan;


public class VkTraceRaysIndirectCommand2KHRHandle : BaseSafeHandle
{
}


public static class VkTraceRaysIndirectCommand2KHRExtensions
{

	public static VkTraceRaysIndirectCommand2KHR Dereference(this VkTraceRaysIndirectCommand2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTraceRaysIndirectCommand2KHR>(x.DangerousGetHandle());
}
internal class VkTraceRaysIndirectCommand2KHRExterns
{
}


public struct VkTraceRaysIndirectCommand2KHR
{
}
