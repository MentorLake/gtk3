namespace MentorLake.Vulkan;

public class VkAccelerationStructureInstanceNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureInstanceNVExtensions
{

	public static VkAccelerationStructureInstanceNV Dereference(this VkAccelerationStructureInstanceNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureInstanceNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureInstanceNVExterns
{
}

public struct VkAccelerationStructureInstanceNV
{
}
