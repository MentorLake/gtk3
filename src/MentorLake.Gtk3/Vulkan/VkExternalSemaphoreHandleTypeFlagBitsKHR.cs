namespace MentorLake.Vulkan;


public class VkExternalSemaphoreHandleTypeFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphoreHandleTypeFlagBitsKHRExtensions
{

	public static VkExternalSemaphoreHandleTypeFlagBitsKHR Dereference(this VkExternalSemaphoreHandleTypeFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphoreHandleTypeFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkExternalSemaphoreHandleTypeFlagBitsKHRExterns
{
}


public struct VkExternalSemaphoreHandleTypeFlagBitsKHR
{
}
