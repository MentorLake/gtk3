namespace MentorLake.Vulkan;

public class VkGeometryInstanceFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkGeometryInstanceFlagsKHRExtensions
{

	public static VkGeometryInstanceFlagsKHR Dereference(this VkGeometryInstanceFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryInstanceFlagsKHR>(x.DangerousGetHandle());
}
internal class VkGeometryInstanceFlagsKHRExterns
{
}

public struct VkGeometryInstanceFlagsKHR
{
}
