namespace MentorLake.Vulkan;


public class VkAccelerationStructureMotionInstanceDataNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureMotionInstanceDataNVExtensions
{

	public static VkAccelerationStructureMotionInstanceDataNV Dereference(this VkAccelerationStructureMotionInstanceDataNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureMotionInstanceDataNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureMotionInstanceDataNVExterns
{
}


public struct VkAccelerationStructureMotionInstanceDataNV
{
}
