namespace MentorLake.Vulkan;

public class VkExternalFenceHandleTypeFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalFenceHandleTypeFlagBitsKHRExtensions
{

	public static VkExternalFenceHandleTypeFlagBitsKHR Dereference(this VkExternalFenceHandleTypeFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFenceHandleTypeFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkExternalFenceHandleTypeFlagBitsKHRExterns
{
}

public struct VkExternalFenceHandleTypeFlagBitsKHR
{
}
