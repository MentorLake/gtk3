namespace MentorLake.Vulkan;


public class VkGeometryInstanceFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkGeometryInstanceFlagBitsKHRExtensions
{

	public static VkGeometryInstanceFlagBitsKHR Dereference(this VkGeometryInstanceFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryInstanceFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkGeometryInstanceFlagBitsKHRExterns
{
}


public struct VkGeometryInstanceFlagBitsKHR
{
}
