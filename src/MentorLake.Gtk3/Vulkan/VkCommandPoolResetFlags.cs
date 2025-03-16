namespace MentorLake.Vulkan;

public class VkCommandPoolResetFlagsHandle : BaseSafeHandle
{
}


public static class VkCommandPoolResetFlagsExtensions
{

	public static VkCommandPoolResetFlags Dereference(this VkCommandPoolResetFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandPoolResetFlags>(x.DangerousGetHandle());
}
internal class VkCommandPoolResetFlagsExterns
{
}

public struct VkCommandPoolResetFlags
{
}
