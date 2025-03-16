namespace MentorLake.Vulkan;

public class VkAcquireProfilingLockInfoKHRHandle : BaseSafeHandle
{
}


public static class VkAcquireProfilingLockInfoKHRExtensions
{

	public static VkAcquireProfilingLockInfoKHR Dereference(this VkAcquireProfilingLockInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAcquireProfilingLockInfoKHR>(x.DangerousGetHandle());
}
internal class VkAcquireProfilingLockInfoKHRExterns
{
}

public struct VkAcquireProfilingLockInfoKHR
{
}
