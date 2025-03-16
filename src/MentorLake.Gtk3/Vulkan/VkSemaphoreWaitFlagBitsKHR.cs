namespace MentorLake.Vulkan;

public class VkSemaphoreWaitFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreWaitFlagBitsKHRExtensions
{

	public static VkSemaphoreWaitFlagBitsKHR Dereference(this VkSemaphoreWaitFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreWaitFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreWaitFlagBitsKHRExterns
{
}

public struct VkSemaphoreWaitFlagBitsKHR
{
}
