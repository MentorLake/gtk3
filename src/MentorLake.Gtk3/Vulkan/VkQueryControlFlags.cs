namespace MentorLake.Vulkan;


public class VkQueryControlFlagsHandle : BaseSafeHandle
{
}


public static class VkQueryControlFlagsExtensions
{

	public static VkQueryControlFlags Dereference(this VkQueryControlFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryControlFlags>(x.DangerousGetHandle());
}
internal class VkQueryControlFlagsExterns
{
}


public struct VkQueryControlFlags
{
}
