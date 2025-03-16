namespace MentorLake.Vulkan;

public class VkColorComponentFlagsHandle : BaseSafeHandle
{
}


public static class VkColorComponentFlagsExtensions
{

	public static VkColorComponentFlags Dereference(this VkColorComponentFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkColorComponentFlags>(x.DangerousGetHandle());
}
internal class VkColorComponentFlagsExterns
{
}

public struct VkColorComponentFlags
{
}
