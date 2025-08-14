namespace MentorLake.Vulkan;


public class VkSemaphoreSignalInfoKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreSignalInfoKHRExtensions
{

	public static VkSemaphoreSignalInfoKHR Dereference(this VkSemaphoreSignalInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreSignalInfoKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreSignalInfoKHRExterns
{
}


public struct VkSemaphoreSignalInfoKHR
{
}
