namespace MentorLake.Vulkan;

public class VkAccelerationStructureVersionInfoKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureVersionInfoKHRExtensions
{

	public static VkAccelerationStructureVersionInfoKHR Dereference(this VkAccelerationStructureVersionInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureVersionInfoKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureVersionInfoKHRExterns
{
}

public struct VkAccelerationStructureVersionInfoKHR
{
}
