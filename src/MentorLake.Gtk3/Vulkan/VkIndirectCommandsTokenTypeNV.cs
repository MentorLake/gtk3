namespace MentorLake.Vulkan;


public class VkIndirectCommandsTokenTypeNVHandle : BaseSafeHandle
{
}


public static class VkIndirectCommandsTokenTypeNVExtensions
{

	public static VkIndirectCommandsTokenTypeNV Dereference(this VkIndirectCommandsTokenTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndirectCommandsTokenTypeNV>(x.DangerousGetHandle());
}
internal class VkIndirectCommandsTokenTypeNVExterns
{
}


public struct VkIndirectCommandsTokenTypeNV
{
}
