namespace MentorLake.Vulkan;


public class VkBufferHandle : BaseSafeHandle
{
}


public static class VkBufferExtensions
{

	public static VkBuffer Dereference(this VkBufferHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBuffer>(x.DangerousGetHandle());
}
internal class VkBufferExterns
{
}


public struct VkBuffer
{
}
