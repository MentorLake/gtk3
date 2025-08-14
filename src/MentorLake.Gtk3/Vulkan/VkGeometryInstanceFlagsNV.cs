namespace MentorLake.Vulkan;


public class VkGeometryInstanceFlagsNVHandle : BaseSafeHandle
{
}


public static class VkGeometryInstanceFlagsNVExtensions
{

	public static VkGeometryInstanceFlagsNV Dereference(this VkGeometryInstanceFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryInstanceFlagsNV>(x.DangerousGetHandle());
}
internal class VkGeometryInstanceFlagsNVExterns
{
}


public struct VkGeometryInstanceFlagsNV
{
}
