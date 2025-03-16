namespace MentorLake.Vulkan;

public class VkSemaphoreWaitInfoHandle : BaseSafeHandle
{
}


public static class VkSemaphoreWaitInfoExtensions
{

	public static VkSemaphoreWaitInfo Dereference(this VkSemaphoreWaitInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreWaitInfo>(x.DangerousGetHandle());
}
internal class VkSemaphoreWaitInfoExterns
{
}

public struct VkSemaphoreWaitInfo
{
}
