namespace MentorLake.Vulkan;

public class VkSemaphoreWaitFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreWaitFlagsKHRExtensions
{

	public static VkSemaphoreWaitFlagsKHR Dereference(this VkSemaphoreWaitFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreWaitFlagsKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreWaitFlagsKHRExterns
{
}

public struct VkSemaphoreWaitFlagsKHR
{
}
