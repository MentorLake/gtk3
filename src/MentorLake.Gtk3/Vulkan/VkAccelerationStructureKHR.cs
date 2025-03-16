namespace MentorLake.Vulkan;

public class VkAccelerationStructureKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureKHRExtensions
{

	public static VkAccelerationStructureKHR Dereference(this VkAccelerationStructureKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureKHRExterns
{
}

public struct VkAccelerationStructureKHR
{
}
