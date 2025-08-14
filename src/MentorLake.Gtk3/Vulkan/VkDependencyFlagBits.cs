namespace MentorLake.Vulkan;


public class VkDependencyFlagBitsHandle : BaseSafeHandle
{
}


public static class VkDependencyFlagBitsExtensions
{

	public static VkDependencyFlagBits Dereference(this VkDependencyFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDependencyFlagBits>(x.DangerousGetHandle());
}
internal class VkDependencyFlagBitsExterns
{
}


public struct VkDependencyFlagBits
{
}
