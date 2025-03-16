namespace MentorLake.Vulkan;

public class VkQueryPoolCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkQueryPoolCreateFlagsExtensions
{

	public static VkQueryPoolCreateFlags Dereference(this VkQueryPoolCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPoolCreateFlags>(x.DangerousGetHandle());
}
internal class VkQueryPoolCreateFlagsExterns
{
}

public struct VkQueryPoolCreateFlags
{
}
