namespace MentorLake.Vulkan;

public class VkBuildAccelerationStructureModeKHRHandle : BaseSafeHandle
{
}


public static class VkBuildAccelerationStructureModeKHRExtensions
{

	public static VkBuildAccelerationStructureModeKHR Dereference(this VkBuildAccelerationStructureModeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBuildAccelerationStructureModeKHR>(x.DangerousGetHandle());
}
internal class VkBuildAccelerationStructureModeKHRExterns
{
}

public struct VkBuildAccelerationStructureModeKHR
{
}
