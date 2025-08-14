namespace MentorLake.Vulkan;


public class VkAccelerationStructureBuildRangeInfoKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureBuildRangeInfoKHRExtensions
{

	public static VkAccelerationStructureBuildRangeInfoKHR Dereference(this VkAccelerationStructureBuildRangeInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureBuildRangeInfoKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureBuildRangeInfoKHRExterns
{
}


public struct VkAccelerationStructureBuildRangeInfoKHR
{
}
