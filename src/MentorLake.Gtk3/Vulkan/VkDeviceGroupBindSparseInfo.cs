namespace MentorLake.Vulkan;


public class VkDeviceGroupBindSparseInfoHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupBindSparseInfoExtensions
{

	public static VkDeviceGroupBindSparseInfo Dereference(this VkDeviceGroupBindSparseInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupBindSparseInfo>(x.DangerousGetHandle());
}
internal class VkDeviceGroupBindSparseInfoExterns
{
}


public struct VkDeviceGroupBindSparseInfo
{
}
