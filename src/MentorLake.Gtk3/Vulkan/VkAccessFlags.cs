namespace MentorLake.Vulkan;


public class VkAccessFlagsHandle : BaseSafeHandle
{
}


public static class VkAccessFlagsExtensions
{

	public static VkAccessFlags Dereference(this VkAccessFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccessFlags>(x.DangerousGetHandle());
}
internal class VkAccessFlagsExterns
{
}


public struct VkAccessFlags
{
}
