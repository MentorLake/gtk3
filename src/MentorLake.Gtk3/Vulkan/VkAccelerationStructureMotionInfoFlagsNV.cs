namespace MentorLake.Vulkan;


public class VkAccelerationStructureMotionInfoFlagsNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureMotionInfoFlagsNVExtensions
{

	public static VkAccelerationStructureMotionInfoFlagsNV Dereference(this VkAccelerationStructureMotionInfoFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureMotionInfoFlagsNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureMotionInfoFlagsNVExterns
{
}


public struct VkAccelerationStructureMotionInfoFlagsNV
{
}
