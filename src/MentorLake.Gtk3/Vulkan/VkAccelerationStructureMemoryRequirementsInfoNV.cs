namespace MentorLake.Vulkan;

public class VkAccelerationStructureMemoryRequirementsInfoNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureMemoryRequirementsInfoNVExtensions
{

	public static VkAccelerationStructureMemoryRequirementsInfoNV Dereference(this VkAccelerationStructureMemoryRequirementsInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureMemoryRequirementsInfoNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureMemoryRequirementsInfoNVExterns
{
}

public struct VkAccelerationStructureMemoryRequirementsInfoNV
{
}
