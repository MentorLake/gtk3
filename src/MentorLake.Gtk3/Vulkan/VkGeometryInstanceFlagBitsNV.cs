namespace MentorLake.Vulkan;


public class VkGeometryInstanceFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkGeometryInstanceFlagBitsNVExtensions
{

	public static VkGeometryInstanceFlagBitsNV Dereference(this VkGeometryInstanceFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryInstanceFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkGeometryInstanceFlagBitsNVExterns
{
}


public struct VkGeometryInstanceFlagBitsNV
{
}
