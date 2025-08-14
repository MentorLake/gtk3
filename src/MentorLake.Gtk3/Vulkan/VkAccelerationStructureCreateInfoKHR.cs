namespace MentorLake.Vulkan;


public class VkAccelerationStructureCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureCreateInfoKHRExtensions
{

	public static VkAccelerationStructureCreateInfoKHR Dereference(this VkAccelerationStructureCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureCreateInfoKHRExterns
{
}


public struct VkAccelerationStructureCreateInfoKHR
{
}
