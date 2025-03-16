namespace MentorLake.Vulkan;

public class VkGeometryFlagsNVHandle : BaseSafeHandle
{
}


public static class VkGeometryFlagsNVExtensions
{

	public static VkGeometryFlagsNV Dereference(this VkGeometryFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryFlagsNV>(x.DangerousGetHandle());
}
internal class VkGeometryFlagsNVExterns
{
}

public struct VkGeometryFlagsNV
{
}
