namespace MentorLake.Vulkan;


public class VkCommandPoolTrimFlagsHandle : BaseSafeHandle
{
}


public static class VkCommandPoolTrimFlagsExtensions
{

	public static VkCommandPoolTrimFlags Dereference(this VkCommandPoolTrimFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandPoolTrimFlags>(x.DangerousGetHandle());
}
internal class VkCommandPoolTrimFlagsExterns
{
}


public struct VkCommandPoolTrimFlags
{
}
