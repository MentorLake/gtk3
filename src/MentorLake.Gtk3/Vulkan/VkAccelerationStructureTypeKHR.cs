namespace MentorLake.Vulkan;


public class VkAccelerationStructureTypeKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureTypeKHRExtensions
{

	public static VkAccelerationStructureTypeKHR Dereference(this VkAccelerationStructureTypeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureTypeKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureTypeKHRExterns
{
}


public struct VkAccelerationStructureTypeKHR
{
}
