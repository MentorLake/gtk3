namespace MentorLake.Vulkan;

public class VkExternalMemoryHandleTypeFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryHandleTypeFlagBitsKHRExtensions
{

	public static VkExternalMemoryHandleTypeFlagBitsKHR Dereference(this VkExternalMemoryHandleTypeFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryHandleTypeFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkExternalMemoryHandleTypeFlagBitsKHRExterns
{
}

public struct VkExternalMemoryHandleTypeFlagBitsKHR
{
}
