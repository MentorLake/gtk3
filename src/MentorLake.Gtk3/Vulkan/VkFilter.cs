namespace MentorLake.Vulkan;


public class VkFilterHandle : BaseSafeHandle
{
}


public static class VkFilterExtensions
{

	public static VkFilter Dereference(this VkFilterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFilter>(x.DangerousGetHandle());
}
internal class VkFilterExterns
{
}


public struct VkFilter
{
}
