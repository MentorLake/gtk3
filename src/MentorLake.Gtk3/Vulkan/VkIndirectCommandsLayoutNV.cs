namespace MentorLake.Vulkan;

public class VkIndirectCommandsLayoutNVHandle : BaseSafeHandle
{
}


public static class VkIndirectCommandsLayoutNVExtensions
{

	public static VkIndirectCommandsLayoutNV Dereference(this VkIndirectCommandsLayoutNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndirectCommandsLayoutNV>(x.DangerousGetHandle());
}
internal class VkIndirectCommandsLayoutNVExterns
{
}

public struct VkIndirectCommandsLayoutNV
{
}
