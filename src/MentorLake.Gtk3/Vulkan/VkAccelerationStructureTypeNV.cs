namespace MentorLake.Vulkan;


public class VkAccelerationStructureTypeNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureTypeNVExtensions
{

	public static VkAccelerationStructureTypeNV Dereference(this VkAccelerationStructureTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureTypeNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureTypeNVExterns
{
}


public struct VkAccelerationStructureTypeNV
{
}
