namespace MentorLake.Vulkan;

public class VkGeometryTrianglesNVHandle : BaseSafeHandle
{
}


public static class VkGeometryTrianglesNVExtensions
{

	public static VkGeometryTrianglesNV Dereference(this VkGeometryTrianglesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryTrianglesNV>(x.DangerousGetHandle());
}
internal class VkGeometryTrianglesNVExterns
{
}

public struct VkGeometryTrianglesNV
{
}
