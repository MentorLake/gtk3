namespace MentorLake.Vulkan;


public class VkExternalFenceHandleTypeFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalFenceHandleTypeFlagsKHRExtensions
{

	public static VkExternalFenceHandleTypeFlagsKHR Dereference(this VkExternalFenceHandleTypeFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFenceHandleTypeFlagsKHR>(x.DangerousGetHandle());
}
internal class VkExternalFenceHandleTypeFlagsKHRExterns
{
}


public struct VkExternalFenceHandleTypeFlagsKHR
{
}
