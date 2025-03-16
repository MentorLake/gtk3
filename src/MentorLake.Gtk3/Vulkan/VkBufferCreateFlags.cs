namespace MentorLake.Vulkan;

public class VkBufferCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkBufferCreateFlagsExtensions
{

	public static VkBufferCreateFlags Dereference(this VkBufferCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferCreateFlags>(x.DangerousGetHandle());
}
internal class VkBufferCreateFlagsExterns
{
}

public struct VkBufferCreateFlags
{
}
