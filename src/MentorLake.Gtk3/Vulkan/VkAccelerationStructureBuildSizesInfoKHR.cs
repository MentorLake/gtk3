namespace MentorLake.Vulkan;

public class VkAccelerationStructureBuildSizesInfoKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureBuildSizesInfoKHRExtensions
{

	public static VkAccelerationStructureBuildSizesInfoKHR Dereference(this VkAccelerationStructureBuildSizesInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureBuildSizesInfoKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureBuildSizesInfoKHRExterns
{
}

public struct VkAccelerationStructureBuildSizesInfoKHR
{
}
