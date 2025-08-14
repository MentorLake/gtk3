namespace MentorLake.Vulkan;


public class VkDisplayModeKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayModeKHRExtensions
{

	public static VkDisplayModeKHR Dereference(this VkDisplayModeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayModeKHR>(x.DangerousGetHandle());
}
internal class VkDisplayModeKHRExterns
{
}


public struct VkDisplayModeKHR
{
}
