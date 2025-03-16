namespace MentorLake.Vulkan;

public class VkSurfaceTransformFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkSurfaceTransformFlagsKHRExtensions
{

	public static VkSurfaceTransformFlagsKHR Dereference(this VkSurfaceTransformFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceTransformFlagsKHR>(x.DangerousGetHandle());
}
internal class VkSurfaceTransformFlagsKHRExterns
{
}

public struct VkSurfaceTransformFlagsKHR
{
}
