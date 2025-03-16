namespace MentorLake.Vulkan;

public class VkAccelerationStructureMotionInstanceFlagsNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureMotionInstanceFlagsNVExtensions
{

	public static VkAccelerationStructureMotionInstanceFlagsNV Dereference(this VkAccelerationStructureMotionInstanceFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureMotionInstanceFlagsNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureMotionInstanceFlagsNVExterns
{
}

public struct VkAccelerationStructureMotionInstanceFlagsNV
{
}
