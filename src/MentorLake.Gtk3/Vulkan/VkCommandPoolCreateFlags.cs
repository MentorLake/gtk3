namespace MentorLake.Vulkan;

public class VkCommandPoolCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkCommandPoolCreateFlagsExtensions
{

	public static VkCommandPoolCreateFlags Dereference(this VkCommandPoolCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandPoolCreateFlags>(x.DangerousGetHandle());
}
internal class VkCommandPoolCreateFlagsExterns
{
}

public struct VkCommandPoolCreateFlags
{
}
