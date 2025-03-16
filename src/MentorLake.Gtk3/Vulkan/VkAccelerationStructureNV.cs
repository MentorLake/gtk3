namespace MentorLake.Vulkan;

public class VkAccelerationStructureNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureNVExtensions
{

	public static VkAccelerationStructureNV Dereference(this VkAccelerationStructureNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureNVExterns
{
}

public struct VkAccelerationStructureNV
{
}
