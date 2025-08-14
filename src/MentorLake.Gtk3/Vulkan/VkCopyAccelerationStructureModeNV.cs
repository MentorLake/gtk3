namespace MentorLake.Vulkan;


public class VkCopyAccelerationStructureModeNVHandle : BaseSafeHandle
{
}


public static class VkCopyAccelerationStructureModeNVExtensions
{

	public static VkCopyAccelerationStructureModeNV Dereference(this VkCopyAccelerationStructureModeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyAccelerationStructureModeNV>(x.DangerousGetHandle());
}
internal class VkCopyAccelerationStructureModeNVExterns
{
}


public struct VkCopyAccelerationStructureModeNV
{
}
