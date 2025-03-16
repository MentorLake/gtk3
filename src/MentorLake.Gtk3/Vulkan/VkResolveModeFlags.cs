namespace MentorLake.Vulkan;

public class VkResolveModeFlagsHandle : BaseSafeHandle
{
}


public static class VkResolveModeFlagsExtensions
{

	public static VkResolveModeFlags Dereference(this VkResolveModeFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkResolveModeFlags>(x.DangerousGetHandle());
}
internal class VkResolveModeFlagsExterns
{
}

public struct VkResolveModeFlags
{
}
