namespace MentorLake.Vulkan;


public class VkGeometryTypeNVHandle : BaseSafeHandle
{
}


public static class VkGeometryTypeNVExtensions
{

	public static VkGeometryTypeNV Dereference(this VkGeometryTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryTypeNV>(x.DangerousGetHandle());
}
internal class VkGeometryTypeNVExterns
{
}


public struct VkGeometryTypeNV
{
}
