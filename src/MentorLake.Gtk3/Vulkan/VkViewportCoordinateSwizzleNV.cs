namespace MentorLake.Vulkan;


public class VkViewportCoordinateSwizzleNVHandle : BaseSafeHandle
{
}


public static class VkViewportCoordinateSwizzleNVExtensions
{

	public static VkViewportCoordinateSwizzleNV Dereference(this VkViewportCoordinateSwizzleNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkViewportCoordinateSwizzleNV>(x.DangerousGetHandle());
}
internal class VkViewportCoordinateSwizzleNVExterns
{
}


public struct VkViewportCoordinateSwizzleNV
{
}
