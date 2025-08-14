namespace MentorLake.Vulkan;


public class VkRenderingAreaInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRenderingAreaInfoKHRExtensions
{

	public static VkRenderingAreaInfoKHR Dereference(this VkRenderingAreaInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingAreaInfoKHR>(x.DangerousGetHandle());
}
internal class VkRenderingAreaInfoKHRExterns
{
}


public struct VkRenderingAreaInfoKHR
{
}
