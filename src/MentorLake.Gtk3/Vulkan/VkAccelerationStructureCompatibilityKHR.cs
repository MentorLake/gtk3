namespace MentorLake.Vulkan;


public class VkAccelerationStructureCompatibilityKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureCompatibilityKHRExtensions
{

	public static VkAccelerationStructureCompatibilityKHR Dereference(this VkAccelerationStructureCompatibilityKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureCompatibilityKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureCompatibilityKHRExterns
{
}


public struct VkAccelerationStructureCompatibilityKHR
{
}
