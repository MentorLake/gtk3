namespace MentorLake.Vulkan;

public class VkBuildAccelerationStructureFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkBuildAccelerationStructureFlagBitsNVExtensions
{

	public static VkBuildAccelerationStructureFlagBitsNV Dereference(this VkBuildAccelerationStructureFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBuildAccelerationStructureFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkBuildAccelerationStructureFlagBitsNVExterns
{
}

public struct VkBuildAccelerationStructureFlagBitsNV
{
}
