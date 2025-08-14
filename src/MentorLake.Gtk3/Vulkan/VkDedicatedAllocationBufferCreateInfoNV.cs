namespace MentorLake.Vulkan;


public class VkDedicatedAllocationBufferCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkDedicatedAllocationBufferCreateInfoNVExtensions
{

	public static VkDedicatedAllocationBufferCreateInfoNV Dereference(this VkDedicatedAllocationBufferCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDedicatedAllocationBufferCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkDedicatedAllocationBufferCreateInfoNVExterns
{
}


public struct VkDedicatedAllocationBufferCreateInfoNV
{
}
