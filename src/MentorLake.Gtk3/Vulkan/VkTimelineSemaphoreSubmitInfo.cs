namespace MentorLake.Vulkan;

public class VkTimelineSemaphoreSubmitInfoHandle : BaseSafeHandle
{
}


public static class VkTimelineSemaphoreSubmitInfoExtensions
{

	public static VkTimelineSemaphoreSubmitInfo Dereference(this VkTimelineSemaphoreSubmitInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTimelineSemaphoreSubmitInfo>(x.DangerousGetHandle());
}
internal class VkTimelineSemaphoreSubmitInfoExterns
{
}

public struct VkTimelineSemaphoreSubmitInfo
{
}
