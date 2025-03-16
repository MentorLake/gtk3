namespace MentorLake.Vulkan;

public class VkDedicatedAllocationImageCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkDedicatedAllocationImageCreateInfoNVExtensions
{

	public static VkDedicatedAllocationImageCreateInfoNV Dereference(this VkDedicatedAllocationImageCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDedicatedAllocationImageCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkDedicatedAllocationImageCreateInfoNVExterns
{
}

public struct VkDedicatedAllocationImageCreateInfoNV
{
}
