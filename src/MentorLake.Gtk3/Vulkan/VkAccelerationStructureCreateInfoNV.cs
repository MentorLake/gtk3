namespace MentorLake.Vulkan;


public class VkAccelerationStructureCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureCreateInfoNVExtensions
{

	public static VkAccelerationStructureCreateInfoNV Dereference(this VkAccelerationStructureCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureCreateInfoNVExterns
{
}


public struct VkAccelerationStructureCreateInfoNV
{
}
