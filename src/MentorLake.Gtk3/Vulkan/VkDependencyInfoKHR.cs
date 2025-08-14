namespace MentorLake.Vulkan;


public class VkDependencyInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDependencyInfoKHRExtensions
{

	public static VkDependencyInfoKHR Dereference(this VkDependencyInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDependencyInfoKHR>(x.DangerousGetHandle());
}
internal class VkDependencyInfoKHRExterns
{
}


public struct VkDependencyInfoKHR
{
}
