namespace MentorLake.Vulkan;

public class VkCullModeFlagsHandle : BaseSafeHandle
{
}


public static class VkCullModeFlagsExtensions
{

	public static VkCullModeFlags Dereference(this VkCullModeFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCullModeFlags>(x.DangerousGetHandle());
}
internal class VkCullModeFlagsExterns
{
}

public struct VkCullModeFlags
{
}
