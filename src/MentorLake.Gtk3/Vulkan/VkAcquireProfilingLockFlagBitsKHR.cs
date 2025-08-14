namespace MentorLake.Vulkan;


public class VkAcquireProfilingLockFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkAcquireProfilingLockFlagBitsKHRExtensions
{

	public static VkAcquireProfilingLockFlagBitsKHR Dereference(this VkAcquireProfilingLockFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAcquireProfilingLockFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkAcquireProfilingLockFlagBitsKHRExterns
{
}


public struct VkAcquireProfilingLockFlagBitsKHR
{
}
