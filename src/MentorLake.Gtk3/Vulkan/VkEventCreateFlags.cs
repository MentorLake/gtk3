namespace MentorLake.Vulkan;

public class VkEventCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkEventCreateFlagsExtensions
{

	public static VkEventCreateFlags Dereference(this VkEventCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkEventCreateFlags>(x.DangerousGetHandle());
}
internal class VkEventCreateFlagsExterns
{
}

public struct VkEventCreateFlags
{
}
