namespace MentorLake.Vulkan;


public class VkBuildAccelerationStructureFlagsNVHandle : BaseSafeHandle
{
}


public static class VkBuildAccelerationStructureFlagsNVExtensions
{

	public static VkBuildAccelerationStructureFlagsNV Dereference(this VkBuildAccelerationStructureFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBuildAccelerationStructureFlagsNV>(x.DangerousGetHandle());
}
internal class VkBuildAccelerationStructureFlagsNVExterns
{
}


public struct VkBuildAccelerationStructureFlagsNV
{
}
