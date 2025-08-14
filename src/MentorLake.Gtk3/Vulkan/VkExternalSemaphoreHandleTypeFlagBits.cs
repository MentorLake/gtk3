namespace MentorLake.Vulkan;


public class VkExternalSemaphoreHandleTypeFlagBitsHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphoreHandleTypeFlagBitsExtensions
{

	public static VkExternalSemaphoreHandleTypeFlagBits Dereference(this VkExternalSemaphoreHandleTypeFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphoreHandleTypeFlagBits>(x.DangerousGetHandle());
}
internal class VkExternalSemaphoreHandleTypeFlagBitsExterns
{
}


public struct VkExternalSemaphoreHandleTypeFlagBits
{
}
