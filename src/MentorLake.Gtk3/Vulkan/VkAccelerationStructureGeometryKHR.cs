namespace MentorLake.Vulkan;


public class VkAccelerationStructureGeometryKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureGeometryKHRExtensions
{

	public static VkAccelerationStructureGeometryKHR Dereference(this VkAccelerationStructureGeometryKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureGeometryKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureGeometryKHRExterns
{
}


public struct VkAccelerationStructureGeometryKHR
{
}
