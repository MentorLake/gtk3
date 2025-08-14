namespace MentorLake.Vulkan;


public class VkRenderingInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRenderingInfoKHRExtensions
{

	public static VkRenderingInfoKHR Dereference(this VkRenderingInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingInfoKHR>(x.DangerousGetHandle());
}
internal class VkRenderingInfoKHRExterns
{
}


public struct VkRenderingInfoKHR
{
}
