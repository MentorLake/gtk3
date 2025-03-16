namespace MentorLake.Vulkan;

public class VkAccelerationStructureMotionInstanceNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureMotionInstanceNVExtensions
{

	public static VkAccelerationStructureMotionInstanceNV Dereference(this VkAccelerationStructureMotionInstanceNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureMotionInstanceNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureMotionInstanceNVExterns
{
}

public struct VkAccelerationStructureMotionInstanceNV
{
}
