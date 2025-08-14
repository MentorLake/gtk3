namespace MentorLake.Vulkan;


public class VkMemoryDedicatedRequirementsKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryDedicatedRequirementsKHRExtensions
{

	public static VkMemoryDedicatedRequirementsKHR Dereference(this VkMemoryDedicatedRequirementsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryDedicatedRequirementsKHR>(x.DangerousGetHandle());
}
internal class VkMemoryDedicatedRequirementsKHRExterns
{
}


public struct VkMemoryDedicatedRequirementsKHR
{
}
