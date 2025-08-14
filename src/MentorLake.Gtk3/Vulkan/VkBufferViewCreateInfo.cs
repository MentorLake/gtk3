namespace MentorLake.Vulkan;


public class VkBufferViewCreateInfoHandle : BaseSafeHandle
{
}


public static class VkBufferViewCreateInfoExtensions
{

	public static VkBufferViewCreateInfo Dereference(this VkBufferViewCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferViewCreateInfo>(x.DangerousGetHandle());
}
internal class VkBufferViewCreateInfoExterns
{
}


public struct VkBufferViewCreateInfo
{
}
