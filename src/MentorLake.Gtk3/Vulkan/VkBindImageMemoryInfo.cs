namespace MentorLake.Vulkan;


public class VkBindImageMemoryInfoHandle : BaseSafeHandle
{
}


public static class VkBindImageMemoryInfoExtensions
{

	public static VkBindImageMemoryInfo Dereference(this VkBindImageMemoryInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindImageMemoryInfo>(x.DangerousGetHandle());
}
internal class VkBindImageMemoryInfoExterns
{
}


public struct VkBindImageMemoryInfo
{
}
