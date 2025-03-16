namespace MentorLake.Vulkan;

public class VkAcquireNextImageInfoKHRHandle : BaseSafeHandle
{
}


public static class VkAcquireNextImageInfoKHRExtensions
{

	public static VkAcquireNextImageInfoKHR Dereference(this VkAcquireNextImageInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAcquireNextImageInfoKHR>(x.DangerousGetHandle());
}
internal class VkAcquireNextImageInfoKHRExterns
{
}

public struct VkAcquireNextImageInfoKHR
{
}
