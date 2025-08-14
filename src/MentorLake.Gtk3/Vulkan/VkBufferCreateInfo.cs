namespace MentorLake.Vulkan;


public class VkBufferCreateInfoHandle : BaseSafeHandle
{
}


public static class VkBufferCreateInfoExtensions
{

	public static VkBufferCreateInfo Dereference(this VkBufferCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferCreateInfo>(x.DangerousGetHandle());
}
internal class VkBufferCreateInfoExterns
{
}


public struct VkBufferCreateInfo
{
}
