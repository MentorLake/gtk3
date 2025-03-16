namespace MentorLake.Vulkan;

public class VkRenderingFlagsHandle : BaseSafeHandle
{
}


public static class VkRenderingFlagsExtensions
{

	public static VkRenderingFlags Dereference(this VkRenderingFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingFlags>(x.DangerousGetHandle());
}
internal class VkRenderingFlagsExterns
{
}

public struct VkRenderingFlags
{
}
