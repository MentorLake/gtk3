namespace MentorLake.Vulkan;


public class VkAccelerationStructureMotionInstanceTypeNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureMotionInstanceTypeNVExtensions
{

	public static VkAccelerationStructureMotionInstanceTypeNV Dereference(this VkAccelerationStructureMotionInstanceTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureMotionInstanceTypeNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureMotionInstanceTypeNVExterns
{
}


public struct VkAccelerationStructureMotionInstanceTypeNV
{
}
