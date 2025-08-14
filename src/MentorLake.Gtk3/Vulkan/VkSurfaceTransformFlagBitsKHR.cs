namespace MentorLake.Vulkan;


public class VkSurfaceTransformFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkSurfaceTransformFlagBitsKHRExtensions
{

	public static VkSurfaceTransformFlagBitsKHR Dereference(this VkSurfaceTransformFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceTransformFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkSurfaceTransformFlagBitsKHRExterns
{
}


public struct VkSurfaceTransformFlagBitsKHR
{
}
