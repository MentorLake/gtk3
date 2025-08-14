namespace MentorLake.Vulkan;


public class VkAccelerationStructureBuildGeometryInfoKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureBuildGeometryInfoKHRExtensions
{

	public static VkAccelerationStructureBuildGeometryInfoKHR Dereference(this VkAccelerationStructureBuildGeometryInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureBuildGeometryInfoKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureBuildGeometryInfoKHRExterns
{
}


public struct VkAccelerationStructureBuildGeometryInfoKHR
{
}
