namespace MentorLake.Vulkan;

public class VkBindIndexBufferIndirectCommandNVHandle : BaseSafeHandle
{
}


public static class VkBindIndexBufferIndirectCommandNVExtensions
{

	public static VkBindIndexBufferIndirectCommandNV Dereference(this VkBindIndexBufferIndirectCommandNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindIndexBufferIndirectCommandNV>(x.DangerousGetHandle());
}
internal class VkBindIndexBufferIndirectCommandNVExterns
{
}

public struct VkBindIndexBufferIndirectCommandNV
{
}
