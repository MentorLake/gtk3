namespace MentorLake.Vulkan;


public class VkCopyAccelerationStructureToMemoryInfoKHRHandle : BaseSafeHandle
{
}


public static class VkCopyAccelerationStructureToMemoryInfoKHRExtensions
{

	public static VkCopyAccelerationStructureToMemoryInfoKHR Dereference(this VkCopyAccelerationStructureToMemoryInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyAccelerationStructureToMemoryInfoKHR>(x.DangerousGetHandle());
}
internal class VkCopyAccelerationStructureToMemoryInfoKHRExterns
{
}


public struct VkCopyAccelerationStructureToMemoryInfoKHR
{
}
