namespace MentorLake.Vulkan;


public class VkSemaphoreWaitFlagsHandle : BaseSafeHandle
{
}


public static class VkSemaphoreWaitFlagsExtensions
{

	public static VkSemaphoreWaitFlags Dereference(this VkSemaphoreWaitFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreWaitFlags>(x.DangerousGetHandle());
}
internal class VkSemaphoreWaitFlagsExterns
{
}


public struct VkSemaphoreWaitFlags
{
}
