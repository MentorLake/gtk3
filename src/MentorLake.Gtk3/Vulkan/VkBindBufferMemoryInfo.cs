namespace MentorLake.Vulkan;


public class VkBindBufferMemoryInfoHandle : BaseSafeHandle
{
}


public static class VkBindBufferMemoryInfoExtensions
{

	public static VkBindBufferMemoryInfo Dereference(this VkBindBufferMemoryInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindBufferMemoryInfo>(x.DangerousGetHandle());
}
internal class VkBindBufferMemoryInfoExterns
{
}


public struct VkBindBufferMemoryInfo
{
}
