namespace MentorLake.Vulkan;

public class VkSemaphoreSubmitInfoHandle : BaseSafeHandle
{
}


public static class VkSemaphoreSubmitInfoExtensions
{

	public static VkSemaphoreSubmitInfo Dereference(this VkSemaphoreSubmitInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreSubmitInfo>(x.DangerousGetHandle());
}
internal class VkSemaphoreSubmitInfoExterns
{
}

public struct VkSemaphoreSubmitInfo
{
}
