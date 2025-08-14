namespace MentorLake.Vulkan;


public class VkSemaphoreWaitFlagBitsHandle : BaseSafeHandle
{
}


public static class VkSemaphoreWaitFlagBitsExtensions
{

	public static VkSemaphoreWaitFlagBits Dereference(this VkSemaphoreWaitFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreWaitFlagBits>(x.DangerousGetHandle());
}
internal class VkSemaphoreWaitFlagBitsExterns
{
}


public struct VkSemaphoreWaitFlagBits
{
}
