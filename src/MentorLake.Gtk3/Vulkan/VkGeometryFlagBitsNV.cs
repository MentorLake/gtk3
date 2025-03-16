namespace MentorLake.Vulkan;

public class VkGeometryFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkGeometryFlagBitsNVExtensions
{

	public static VkGeometryFlagBitsNV Dereference(this VkGeometryFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkGeometryFlagBitsNVExterns
{
}

public struct VkGeometryFlagBitsNV
{
}
