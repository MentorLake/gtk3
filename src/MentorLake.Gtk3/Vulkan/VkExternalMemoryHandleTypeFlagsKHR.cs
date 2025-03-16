namespace MentorLake.Vulkan;

public class VkExternalMemoryHandleTypeFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryHandleTypeFlagsKHRExtensions
{

	public static VkExternalMemoryHandleTypeFlagsKHR Dereference(this VkExternalMemoryHandleTypeFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryHandleTypeFlagsKHR>(x.DangerousGetHandle());
}
internal class VkExternalMemoryHandleTypeFlagsKHRExterns
{
}

public struct VkExternalMemoryHandleTypeFlagsKHR
{
}
