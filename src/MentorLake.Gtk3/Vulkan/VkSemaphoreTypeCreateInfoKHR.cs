namespace MentorLake.Vulkan;


public class VkSemaphoreTypeCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreTypeCreateInfoKHRExtensions
{

	public static VkSemaphoreTypeCreateInfoKHR Dereference(this VkSemaphoreTypeCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreTypeCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreTypeCreateInfoKHRExterns
{
}


public struct VkSemaphoreTypeCreateInfoKHR
{
}
