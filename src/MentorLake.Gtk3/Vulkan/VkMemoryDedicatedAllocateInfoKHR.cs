namespace MentorLake.Vulkan;


public class VkMemoryDedicatedAllocateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryDedicatedAllocateInfoKHRExtensions
{

	public static VkMemoryDedicatedAllocateInfoKHR Dereference(this VkMemoryDedicatedAllocateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryDedicatedAllocateInfoKHR>(x.DangerousGetHandle());
}
internal class VkMemoryDedicatedAllocateInfoKHRExterns
{
}


public struct VkMemoryDedicatedAllocateInfoKHR
{
}
