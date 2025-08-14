namespace MentorLake.Vulkan;


public class VkGeometryAABBNVHandle : BaseSafeHandle
{
}


public static class VkGeometryAABBNVExtensions
{

	public static VkGeometryAABBNV Dereference(this VkGeometryAABBNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryAABBNV>(x.DangerousGetHandle());
}
internal class VkGeometryAABBNVExterns
{
}


public struct VkGeometryAABBNV
{
}
