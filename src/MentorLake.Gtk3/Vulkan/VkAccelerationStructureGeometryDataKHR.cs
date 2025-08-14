namespace MentorLake.Vulkan;


public class VkAccelerationStructureGeometryDataKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureGeometryDataKHRExtensions
{

	public static VkAccelerationStructureGeometryDataKHR Dereference(this VkAccelerationStructureGeometryDataKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureGeometryDataKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureGeometryDataKHRExterns
{
}


public struct VkAccelerationStructureGeometryDataKHR
{
}
