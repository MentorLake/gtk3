namespace MentorLake.Vulkan;

public class VkGeometryDataNVHandle : BaseSafeHandle
{
}


public static class VkGeometryDataNVExtensions
{

	public static VkGeometryDataNV Dereference(this VkGeometryDataNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryDataNV>(x.DangerousGetHandle());
}
internal class VkGeometryDataNVExterns
{
}

public struct VkGeometryDataNV
{
}
