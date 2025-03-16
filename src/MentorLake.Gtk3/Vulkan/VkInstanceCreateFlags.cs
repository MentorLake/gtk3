namespace MentorLake.Vulkan;

public class VkInstanceCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkInstanceCreateFlagsExtensions
{

	public static VkInstanceCreateFlags Dereference(this VkInstanceCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkInstanceCreateFlags>(x.DangerousGetHandle());
}
internal class VkInstanceCreateFlagsExterns
{
}

public struct VkInstanceCreateFlags
{
}
