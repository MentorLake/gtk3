namespace MentorLake.Vulkan;


public class VkMemoryMapInfoKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryMapInfoKHRExtensions
{

	public static VkMemoryMapInfoKHR Dereference(this VkMemoryMapInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryMapInfoKHR>(x.DangerousGetHandle());
}
internal class VkMemoryMapInfoKHRExterns
{
}


public struct VkMemoryMapInfoKHR
{
}
