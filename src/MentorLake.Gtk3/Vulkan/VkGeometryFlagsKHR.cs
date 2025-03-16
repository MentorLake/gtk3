namespace MentorLake.Vulkan;

public class VkGeometryFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkGeometryFlagsKHRExtensions
{

	public static VkGeometryFlagsKHR Dereference(this VkGeometryFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryFlagsKHR>(x.DangerousGetHandle());
}
internal class VkGeometryFlagsKHRExterns
{
}

public struct VkGeometryFlagsKHR
{
}
