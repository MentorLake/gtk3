namespace MentorLake.Vulkan;


public class VkBindPipelineIndirectCommandNVHandle : BaseSafeHandle
{
}


public static class VkBindPipelineIndirectCommandNVExtensions
{

	public static VkBindPipelineIndirectCommandNV Dereference(this VkBindPipelineIndirectCommandNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindPipelineIndirectCommandNV>(x.DangerousGetHandle());
}
internal class VkBindPipelineIndirectCommandNVExterns
{
}


public struct VkBindPipelineIndirectCommandNV
{
}
