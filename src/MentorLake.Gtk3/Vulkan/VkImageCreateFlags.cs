namespace MentorLake.Vulkan;

public class VkImageCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkImageCreateFlagsExtensions
{

	public static VkImageCreateFlags Dereference(this VkImageCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCreateFlags>(x.DangerousGetHandle());
}
internal class VkImageCreateFlagsExterns
{
}

public struct VkImageCreateFlags
{
}
