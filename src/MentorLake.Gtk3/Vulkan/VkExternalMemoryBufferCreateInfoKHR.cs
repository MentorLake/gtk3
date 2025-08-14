namespace MentorLake.Vulkan;


public class VkExternalMemoryBufferCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryBufferCreateInfoKHRExtensions
{

	public static VkExternalMemoryBufferCreateInfoKHR Dereference(this VkExternalMemoryBufferCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryBufferCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkExternalMemoryBufferCreateInfoKHRExterns
{
}


public struct VkExternalMemoryBufferCreateInfoKHR
{
}
