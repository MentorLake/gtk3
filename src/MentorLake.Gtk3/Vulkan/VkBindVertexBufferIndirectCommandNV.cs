namespace MentorLake.Vulkan;


public class VkBindVertexBufferIndirectCommandNVHandle : BaseSafeHandle
{
}


public static class VkBindVertexBufferIndirectCommandNVExtensions
{

	public static VkBindVertexBufferIndirectCommandNV Dereference(this VkBindVertexBufferIndirectCommandNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindVertexBufferIndirectCommandNV>(x.DangerousGetHandle());
}
internal class VkBindVertexBufferIndirectCommandNVExterns
{
}


public struct VkBindVertexBufferIndirectCommandNV
{
}
