namespace MentorLake.Vulkan;

public class VkAccelerationStructureMemoryRequirementsTypeNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureMemoryRequirementsTypeNVExtensions
{

	public static VkAccelerationStructureMemoryRequirementsTypeNV Dereference(this VkAccelerationStructureMemoryRequirementsTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureMemoryRequirementsTypeNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureMemoryRequirementsTypeNVExterns
{
}

public struct VkAccelerationStructureMemoryRequirementsTypeNV
{
}
