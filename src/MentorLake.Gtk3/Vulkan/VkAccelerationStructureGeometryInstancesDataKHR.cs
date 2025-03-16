namespace MentorLake.Vulkan;

public class VkAccelerationStructureGeometryInstancesDataKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureGeometryInstancesDataKHRExtensions
{

	public static VkAccelerationStructureGeometryInstancesDataKHR Dereference(this VkAccelerationStructureGeometryInstancesDataKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureGeometryInstancesDataKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureGeometryInstancesDataKHRExterns
{
}

public struct VkAccelerationStructureGeometryInstancesDataKHR
{
}
