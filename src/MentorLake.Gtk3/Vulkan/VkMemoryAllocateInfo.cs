namespace MentorLake.Vulkan;


public class VkMemoryAllocateInfoHandle : BaseSafeHandle
{
}


public static class VkMemoryAllocateInfoExtensions
{

	public static VkMemoryAllocateInfo Dereference(this VkMemoryAllocateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryAllocateInfo>(x.DangerousGetHandle());
}
internal class VkMemoryAllocateInfoExterns
{
}


public struct VkMemoryAllocateInfo
{
}
