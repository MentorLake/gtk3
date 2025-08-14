namespace MentorLake.Vulkan;


public class VkSubpassBeginInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSubpassBeginInfoKHRExtensions
{

	public static VkSubpassBeginInfoKHR Dereference(this VkSubpassBeginInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassBeginInfoKHR>(x.DangerousGetHandle());
}
internal class VkSubpassBeginInfoKHRExterns
{
}


public struct VkSubpassBeginInfoKHR
{
}
