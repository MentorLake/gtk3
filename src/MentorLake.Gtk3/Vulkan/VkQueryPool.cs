namespace MentorLake.Vulkan;

public class VkQueryPoolHandle : BaseSafeHandle
{
}


public static class VkQueryPoolExtensions
{

	public static VkQueryPool Dereference(this VkQueryPoolHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPool>(x.DangerousGetHandle());
}
internal class VkQueryPoolExterns
{
}

public struct VkQueryPool
{
}
