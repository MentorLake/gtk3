namespace MentorLake.Vulkan;


public class VkDisplayModeCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayModeCreateInfoKHRExtensions
{

	public static VkDisplayModeCreateInfoKHR Dereference(this VkDisplayModeCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayModeCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkDisplayModeCreateInfoKHRExterns
{
}


public struct VkDisplayModeCreateInfoKHR
{
}
