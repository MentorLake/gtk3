namespace MentorLake.Vulkan;


public class VkSubpassEndInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSubpassEndInfoKHRExtensions
{

	public static VkSubpassEndInfoKHR Dereference(this VkSubpassEndInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassEndInfoKHR>(x.DangerousGetHandle());
}
internal class VkSubpassEndInfoKHRExterns
{
}


public struct VkSubpassEndInfoKHR
{
}
