namespace MentorLake.Vulkan;

public class VkAccelerationStructureSRTMotionInstanceNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureSRTMotionInstanceNVExtensions
{

	public static VkAccelerationStructureSRTMotionInstanceNV Dereference(this VkAccelerationStructureSRTMotionInstanceNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureSRTMotionInstanceNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureSRTMotionInstanceNVExterns
{
}

public struct VkAccelerationStructureSRTMotionInstanceNV
{
}
