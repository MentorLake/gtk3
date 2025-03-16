namespace MentorLake.Vulkan;

public class VkAccelerationStructureCreateFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureCreateFlagsKHRExtensions
{

	public static VkAccelerationStructureCreateFlagsKHR Dereference(this VkAccelerationStructureCreateFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureCreateFlagsKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureCreateFlagsKHRExterns
{
}

public struct VkAccelerationStructureCreateFlagsKHR
{
}
