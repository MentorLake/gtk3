namespace MentorLake.Vulkan;


public class VkCopyAccelerationStructureInfoKHRHandle : BaseSafeHandle
{
}


public static class VkCopyAccelerationStructureInfoKHRExtensions
{

	public static VkCopyAccelerationStructureInfoKHR Dereference(this VkCopyAccelerationStructureInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyAccelerationStructureInfoKHR>(x.DangerousGetHandle());
}
internal class VkCopyAccelerationStructureInfoKHRExterns
{
}


public struct VkCopyAccelerationStructureInfoKHR
{
}
