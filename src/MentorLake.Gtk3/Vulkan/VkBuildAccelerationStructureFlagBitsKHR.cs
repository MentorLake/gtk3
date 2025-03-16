namespace MentorLake.Vulkan;

public class VkBuildAccelerationStructureFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkBuildAccelerationStructureFlagBitsKHRExtensions
{

	public static VkBuildAccelerationStructureFlagBitsKHR Dereference(this VkBuildAccelerationStructureFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBuildAccelerationStructureFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkBuildAccelerationStructureFlagBitsKHRExterns
{
}

public struct VkBuildAccelerationStructureFlagBitsKHR
{
}
