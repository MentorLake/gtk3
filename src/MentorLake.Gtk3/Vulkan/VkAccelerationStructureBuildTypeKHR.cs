namespace MentorLake.Vulkan;

public class VkAccelerationStructureBuildTypeKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureBuildTypeKHRExtensions
{

	public static VkAccelerationStructureBuildTypeKHR Dereference(this VkAccelerationStructureBuildTypeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureBuildTypeKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureBuildTypeKHRExterns
{
}

public struct VkAccelerationStructureBuildTypeKHR
{
}
