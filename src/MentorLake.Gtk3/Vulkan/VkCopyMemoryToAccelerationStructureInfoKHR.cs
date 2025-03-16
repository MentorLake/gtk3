namespace MentorLake.Vulkan;

public class VkCopyMemoryToAccelerationStructureInfoKHRHandle : BaseSafeHandle
{
}


public static class VkCopyMemoryToAccelerationStructureInfoKHRExtensions
{

	public static VkCopyMemoryToAccelerationStructureInfoKHR Dereference(this VkCopyMemoryToAccelerationStructureInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyMemoryToAccelerationStructureInfoKHR>(x.DangerousGetHandle());
}
internal class VkCopyMemoryToAccelerationStructureInfoKHRExterns
{
}

public struct VkCopyMemoryToAccelerationStructureInfoKHR
{
}
