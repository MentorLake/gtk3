namespace MentorLake.Vulkan;

public class VkMappedMemoryRangeHandle : BaseSafeHandle
{
}


public static class VkMappedMemoryRangeExtensions
{

	public static VkMappedMemoryRange Dereference(this VkMappedMemoryRangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMappedMemoryRange>(x.DangerousGetHandle());
}
internal class VkMappedMemoryRangeExterns
{
}

public struct VkMappedMemoryRange
{
}
