namespace MentorLake.Vulkan;


public class VkGeometryFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkGeometryFlagBitsKHRExtensions
{

	public static VkGeometryFlagBitsKHR Dereference(this VkGeometryFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkGeometryFlagBitsKHRExterns
{
}


public struct VkGeometryFlagBitsKHR
{
}
