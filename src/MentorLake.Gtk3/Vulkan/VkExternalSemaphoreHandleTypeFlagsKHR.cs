namespace MentorLake.Vulkan;


public class VkExternalSemaphoreHandleTypeFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphoreHandleTypeFlagsKHRExtensions
{

	public static VkExternalSemaphoreHandleTypeFlagsKHR Dereference(this VkExternalSemaphoreHandleTypeFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphoreHandleTypeFlagsKHR>(x.DangerousGetHandle());
}
internal class VkExternalSemaphoreHandleTypeFlagsKHRExterns
{
}


public struct VkExternalSemaphoreHandleTypeFlagsKHR
{
}
