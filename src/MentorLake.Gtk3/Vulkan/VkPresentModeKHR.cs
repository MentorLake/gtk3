namespace MentorLake.Vulkan;


public class VkPresentModeKHRHandle : BaseSafeHandle
{
}


public static class VkPresentModeKHRExtensions
{

	public static VkPresentModeKHR Dereference(this VkPresentModeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentModeKHR>(x.DangerousGetHandle());
}
internal class VkPresentModeKHRExterns
{
}


public struct VkPresentModeKHR
{
}
