namespace MentorLake.Vulkan;


public class VkBufferViewCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkBufferViewCreateFlagsExtensions
{

	public static VkBufferViewCreateFlags Dereference(this VkBufferViewCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferViewCreateFlags>(x.DangerousGetHandle());
}
internal class VkBufferViewCreateFlagsExterns
{
}


public struct VkBufferViewCreateFlags
{
}
