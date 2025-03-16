namespace MentorLake.Vulkan;

public class VkBufferUsageFlagBitsHandle : BaseSafeHandle
{
}


public static class VkBufferUsageFlagBitsExtensions
{

	public static VkBufferUsageFlagBits Dereference(this VkBufferUsageFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferUsageFlagBits>(x.DangerousGetHandle());
}
internal class VkBufferUsageFlagBitsExterns
{
}

public struct VkBufferUsageFlagBits
{
}
