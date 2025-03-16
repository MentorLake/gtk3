namespace MentorLake.Vulkan;

public class VkTimelineSemaphoreSubmitInfoKHRHandle : BaseSafeHandle
{
}


public static class VkTimelineSemaphoreSubmitInfoKHRExtensions
{

	public static VkTimelineSemaphoreSubmitInfoKHR Dereference(this VkTimelineSemaphoreSubmitInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTimelineSemaphoreSubmitInfoKHR>(x.DangerousGetHandle());
}
internal class VkTimelineSemaphoreSubmitInfoKHRExterns
{
}

public struct VkTimelineSemaphoreSubmitInfoKHR
{
}
