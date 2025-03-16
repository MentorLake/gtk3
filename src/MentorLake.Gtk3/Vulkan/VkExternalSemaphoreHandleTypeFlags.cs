namespace MentorLake.Vulkan;

public class VkExternalSemaphoreHandleTypeFlagsHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphoreHandleTypeFlagsExtensions
{

	public static VkExternalSemaphoreHandleTypeFlags Dereference(this VkExternalSemaphoreHandleTypeFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphoreHandleTypeFlags>(x.DangerousGetHandle());
}
internal class VkExternalSemaphoreHandleTypeFlagsExterns
{
}

public struct VkExternalSemaphoreHandleTypeFlags
{
}
