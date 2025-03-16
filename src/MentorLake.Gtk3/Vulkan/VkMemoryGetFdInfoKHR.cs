namespace MentorLake.Vulkan;

public class VkMemoryGetFdInfoKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryGetFdInfoKHRExtensions
{

	public static VkMemoryGetFdInfoKHR Dereference(this VkMemoryGetFdInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryGetFdInfoKHR>(x.DangerousGetHandle());
}
internal class VkMemoryGetFdInfoKHRExterns
{
}

public struct VkMemoryGetFdInfoKHR
{
}
