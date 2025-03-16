namespace MentorLake.Vulkan;

public class VkDedicatedAllocationMemoryAllocateInfoNVHandle : BaseSafeHandle
{
}


public static class VkDedicatedAllocationMemoryAllocateInfoNVExtensions
{

	public static VkDedicatedAllocationMemoryAllocateInfoNV Dereference(this VkDedicatedAllocationMemoryAllocateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDedicatedAllocationMemoryAllocateInfoNV>(x.DangerousGetHandle());
}
internal class VkDedicatedAllocationMemoryAllocateInfoNVExterns
{
}

public struct VkDedicatedAllocationMemoryAllocateInfoNV
{
}
