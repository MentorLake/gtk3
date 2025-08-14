namespace MentorLake.Vulkan;


public class VkConformanceVersionKHRHandle : BaseSafeHandle
{
}


public static class VkConformanceVersionKHRExtensions
{

	public static VkConformanceVersionKHR Dereference(this VkConformanceVersionKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkConformanceVersionKHR>(x.DangerousGetHandle());
}
internal class VkConformanceVersionKHRExterns
{
}


public struct VkConformanceVersionKHR
{
}
