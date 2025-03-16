namespace MentorLake.Vulkan;

public class VkViewportSwizzleNVHandle : BaseSafeHandle
{
}


public static class VkViewportSwizzleNVExtensions
{

	public static VkViewportSwizzleNV Dereference(this VkViewportSwizzleNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkViewportSwizzleNV>(x.DangerousGetHandle());
}
internal class VkViewportSwizzleNVExterns
{
}

public struct VkViewportSwizzleNV
{
}
