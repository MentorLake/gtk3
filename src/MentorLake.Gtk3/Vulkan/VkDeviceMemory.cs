namespace MentorLake.Vulkan;

public class VkDeviceMemoryHandle : BaseSafeHandle
{
}


public static class VkDeviceMemoryExtensions
{

	public static VkDeviceMemory Dereference(this VkDeviceMemoryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceMemory>(x.DangerousGetHandle());
}
internal class VkDeviceMemoryExterns
{
}

public struct VkDeviceMemory
{
}
