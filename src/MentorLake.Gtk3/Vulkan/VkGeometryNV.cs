namespace MentorLake.Vulkan;


public class VkGeometryNVHandle : BaseSafeHandle
{
}


public static class VkGeometryNVExtensions
{

	public static VkGeometryNV Dereference(this VkGeometryNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryNV>(x.DangerousGetHandle());
}
internal class VkGeometryNVExterns
{
}


public struct VkGeometryNV
{
}
