namespace MentorLake.Vulkan;

public class VkAcquireProfilingLockFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkAcquireProfilingLockFlagsKHRExtensions
{

	public static VkAcquireProfilingLockFlagsKHR Dereference(this VkAcquireProfilingLockFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAcquireProfilingLockFlagsKHR>(x.DangerousGetHandle());
}
internal class VkAcquireProfilingLockFlagsKHRExterns
{
}

public struct VkAcquireProfilingLockFlagsKHR
{
}
