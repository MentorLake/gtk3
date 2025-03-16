namespace MentorLake.Vulkan;

public class VkRenderingFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkRenderingFlagsKHRExtensions
{

	public static VkRenderingFlagsKHR Dereference(this VkRenderingFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingFlagsKHR>(x.DangerousGetHandle());
}
internal class VkRenderingFlagsKHRExterns
{
}

public struct VkRenderingFlagsKHR
{
}
