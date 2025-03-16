namespace MentorLake.Vulkan;

public class VkAccelerationStructureInfoNVHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureInfoNVExtensions
{

	public static VkAccelerationStructureInfoNV Dereference(this VkAccelerationStructureInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureInfoNV>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureInfoNVExterns
{
}

public struct VkAccelerationStructureInfoNV
{
}
