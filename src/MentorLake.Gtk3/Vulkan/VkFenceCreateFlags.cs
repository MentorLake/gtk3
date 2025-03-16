namespace MentorLake.Vulkan;

public class VkFenceCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkFenceCreateFlagsExtensions
{

	public static VkFenceCreateFlags Dereference(this VkFenceCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFenceCreateFlags>(x.DangerousGetHandle());
}
internal class VkFenceCreateFlagsExterns
{
}

public struct VkFenceCreateFlags
{
}
