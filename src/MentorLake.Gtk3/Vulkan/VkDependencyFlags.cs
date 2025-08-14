namespace MentorLake.Vulkan;


public class VkDependencyFlagsHandle : BaseSafeHandle
{
}


public static class VkDependencyFlagsExtensions
{

	public static VkDependencyFlags Dereference(this VkDependencyFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDependencyFlags>(x.DangerousGetHandle());
}
internal class VkDependencyFlagsExterns
{
}


public struct VkDependencyFlags
{
}
