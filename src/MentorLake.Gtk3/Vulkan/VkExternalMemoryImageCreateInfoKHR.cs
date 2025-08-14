namespace MentorLake.Vulkan;


public class VkExternalMemoryImageCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryImageCreateInfoKHRExtensions
{

	public static VkExternalMemoryImageCreateInfoKHR Dereference(this VkExternalMemoryImageCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryImageCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkExternalMemoryImageCreateInfoKHRExterns
{
}


public struct VkExternalMemoryImageCreateInfoKHR
{
}
