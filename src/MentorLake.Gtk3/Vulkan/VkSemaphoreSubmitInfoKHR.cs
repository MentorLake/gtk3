namespace MentorLake.Vulkan;

public class VkSemaphoreSubmitInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreSubmitInfoKHRExtensions
{

	public static VkSemaphoreSubmitInfoKHR Dereference(this VkSemaphoreSubmitInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreSubmitInfoKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreSubmitInfoKHRExterns
{
}

public struct VkSemaphoreSubmitInfoKHR
{
}
