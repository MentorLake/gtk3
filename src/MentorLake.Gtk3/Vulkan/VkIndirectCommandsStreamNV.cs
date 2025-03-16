namespace MentorLake.Vulkan;

public class VkIndirectCommandsStreamNVHandle : BaseSafeHandle
{
}


public static class VkIndirectCommandsStreamNVExtensions
{

	public static VkIndirectCommandsStreamNV Dereference(this VkIndirectCommandsStreamNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndirectCommandsStreamNV>(x.DangerousGetHandle());
}
internal class VkIndirectCommandsStreamNVExterns
{
}

public struct VkIndirectCommandsStreamNV
{
}
