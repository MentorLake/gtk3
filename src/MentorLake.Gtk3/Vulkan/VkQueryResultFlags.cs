namespace MentorLake.Vulkan;

public class VkQueryResultFlagsHandle : BaseSafeHandle
{
}


public static class VkQueryResultFlagsExtensions
{

	public static VkQueryResultFlags Dereference(this VkQueryResultFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryResultFlags>(x.DangerousGetHandle());
}
internal class VkQueryResultFlagsExterns
{
}

public struct VkQueryResultFlags
{
}
