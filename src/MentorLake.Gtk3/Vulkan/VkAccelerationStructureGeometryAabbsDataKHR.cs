namespace MentorLake.Vulkan;

public class VkAccelerationStructureGeometryAabbsDataKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureGeometryAabbsDataKHRExtensions
{

	public static VkAccelerationStructureGeometryAabbsDataKHR Dereference(this VkAccelerationStructureGeometryAabbsDataKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureGeometryAabbsDataKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureGeometryAabbsDataKHRExterns
{
}

public struct VkAccelerationStructureGeometryAabbsDataKHR
{
}
