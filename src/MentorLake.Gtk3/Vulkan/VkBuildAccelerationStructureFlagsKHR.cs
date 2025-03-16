namespace MentorLake.Vulkan;

public class VkBuildAccelerationStructureFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkBuildAccelerationStructureFlagsKHRExtensions
{

	public static VkBuildAccelerationStructureFlagsKHR Dereference(this VkBuildAccelerationStructureFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBuildAccelerationStructureFlagsKHR>(x.DangerousGetHandle());
}
internal class VkBuildAccelerationStructureFlagsKHRExterns
{
}

public struct VkBuildAccelerationStructureFlagsKHR
{
}
