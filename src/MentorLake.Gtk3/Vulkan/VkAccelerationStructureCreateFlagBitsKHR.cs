namespace MentorLake.Vulkan;


public class VkAccelerationStructureCreateFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureCreateFlagBitsKHRExtensions
{

	public static VkAccelerationStructureCreateFlagBitsKHR Dereference(this VkAccelerationStructureCreateFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureCreateFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureCreateFlagBitsKHRExterns
{
}


public struct VkAccelerationStructureCreateFlagBitsKHR
{
}
