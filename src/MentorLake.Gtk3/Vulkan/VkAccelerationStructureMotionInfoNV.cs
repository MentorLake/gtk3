namespace MentorLake.Vulkan;


public class VkAccelerationStructureMotionInfoNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureMotionInfoNVExtensions
{

	public static VkAccelerationStructureMotionInfoNV Dereference(this VkAccelerationStructureMotionInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureMotionInfoNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureMotionInfoNVExterns
{
}


public struct VkAccelerationStructureMotionInfoNV
{
}
