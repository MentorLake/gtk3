namespace MentorLake.Vulkan;


public class VkConformanceVersionHandle : BaseSafeHandle
{
}


public static class VkConformanceVersionExtensions
{

	public static VkConformanceVersion Dereference(this VkConformanceVersionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkConformanceVersion>(x.DangerousGetHandle());
}
internal class VkConformanceVersionExterns
{
}


public struct VkConformanceVersion
{
}
