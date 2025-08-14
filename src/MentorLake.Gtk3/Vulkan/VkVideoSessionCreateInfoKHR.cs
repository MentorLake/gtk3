namespace MentorLake.Vulkan;


public class VkVideoSessionCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoSessionCreateInfoKHRExtensions
{

	public static VkVideoSessionCreateInfoKHR Dereference(this VkVideoSessionCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoSessionCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoSessionCreateInfoKHRExterns
{
}


public struct VkVideoSessionCreateInfoKHR
{
}
