namespace MentorLake.Vulkan;

public class VkFlagsHandle : BaseSafeHandle
{
}


public static class VkFlagsExtensions
{

	public static VkFlags Dereference(this VkFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFlags>(x.DangerousGetHandle());
}
internal class VkFlagsExterns
{
}

public struct VkFlags
{
}
