namespace MentorLake.Vulkan;


public class VkBufferCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkBufferCreateFlagBitsExtensions
{

	public static VkBufferCreateFlagBits Dereference(this VkBufferCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkBufferCreateFlagBitsExterns
{
}


public struct VkBufferCreateFlagBits
{
}
