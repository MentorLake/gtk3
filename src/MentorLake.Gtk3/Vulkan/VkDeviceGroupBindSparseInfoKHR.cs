namespace MentorLake.Vulkan;

public class VkDeviceGroupBindSparseInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupBindSparseInfoKHRExtensions
{

	public static VkDeviceGroupBindSparseInfoKHR Dereference(this VkDeviceGroupBindSparseInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupBindSparseInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupBindSparseInfoKHRExterns
{
}

public struct VkDeviceGroupBindSparseInfoKHR
{
}
