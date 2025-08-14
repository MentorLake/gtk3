namespace MentorLake.Vulkan;


public class VkBindAccelerationStructureMemoryInfoNVHandle : BaseSafeHandle
{
}


public static class VkBindAccelerationStructureMemoryInfoNVExtensions
{

	public static VkBindAccelerationStructureMemoryInfoNV Dereference(this VkBindAccelerationStructureMemoryInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindAccelerationStructureMemoryInfoNV>(x.DangerousGetHandle());
}
internal class VkBindAccelerationStructureMemoryInfoNVExterns
{
}


public struct VkBindAccelerationStructureMemoryInfoNV
{
}
