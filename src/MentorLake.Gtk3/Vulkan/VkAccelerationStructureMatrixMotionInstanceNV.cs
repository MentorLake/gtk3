namespace MentorLake.Vulkan;

public class VkAccelerationStructureMatrixMotionInstanceNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureMatrixMotionInstanceNVExtensions
{

	public static VkAccelerationStructureMatrixMotionInstanceNV Dereference(this VkAccelerationStructureMatrixMotionInstanceNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureMatrixMotionInstanceNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureMatrixMotionInstanceNVExterns
{
}

public struct VkAccelerationStructureMatrixMotionInstanceNV
{
}
