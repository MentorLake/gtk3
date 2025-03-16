namespace MentorLake.Vulkan;

public class VkCommandPoolHandle : BaseSafeHandle
{
}


public static class VkCommandPoolExtensions
{

	public static VkCommandPool Dereference(this VkCommandPoolHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandPool>(x.DangerousGetHandle());
}
internal class VkCommandPoolExterns
{
}

public struct VkCommandPool
{
}
