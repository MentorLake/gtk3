namespace MentorLake.Vulkan;


public class VkCopyAccelerationStructureModeKHRHandle : BaseSafeHandle
{
}


public static class VkCopyAccelerationStructureModeKHRExtensions
{

	public static VkCopyAccelerationStructureModeKHR Dereference(this VkCopyAccelerationStructureModeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyAccelerationStructureModeKHR>(x.DangerousGetHandle());
}
internal class VkCopyAccelerationStructureModeKHRExterns
{
}


public struct VkCopyAccelerationStructureModeKHR
{
}
