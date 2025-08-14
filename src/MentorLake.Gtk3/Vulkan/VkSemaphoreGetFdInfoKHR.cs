namespace MentorLake.Vulkan;


public class VkSemaphoreGetFdInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreGetFdInfoKHRExtensions
{

	public static VkSemaphoreGetFdInfoKHR Dereference(this VkSemaphoreGetFdInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreGetFdInfoKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreGetFdInfoKHRExterns
{
}


public struct VkSemaphoreGetFdInfoKHR
{
}
