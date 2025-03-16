namespace MentorLake.Vulkan;

public class VkRefreshCycleDurationGOOGLEHandle : BaseSafeHandle
{
}


public static class VkRefreshCycleDurationGOOGLEExtensions
{

	public static VkRefreshCycleDurationGOOGLE Dereference(this VkRefreshCycleDurationGOOGLEHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRefreshCycleDurationGOOGLE>(x.DangerousGetHandle());
}
internal class VkRefreshCycleDurationGOOGLEExterns
{
}

public struct VkRefreshCycleDurationGOOGLE
{
}
