namespace MentorLake.Vulkan;

public class VkAccelerationStructureGeometryTrianglesDataKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureGeometryTrianglesDataKHRExtensions
{

	public static VkAccelerationStructureGeometryTrianglesDataKHR Dereference(this VkAccelerationStructureGeometryTrianglesDataKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureGeometryTrianglesDataKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureGeometryTrianglesDataKHRExterns
{
}

public struct VkAccelerationStructureGeometryTrianglesDataKHR
{
}
