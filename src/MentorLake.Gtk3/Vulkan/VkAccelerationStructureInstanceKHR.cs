namespace MentorLake.Vulkan;

public class VkAccelerationStructureInstanceKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureInstanceKHRExtensions
{

	public static VkAccelerationStructureInstanceKHR Dereference(this VkAccelerationStructureInstanceKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureInstanceKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureInstanceKHRExterns
{
}

public struct VkAccelerationStructureInstanceKHR
{
}
