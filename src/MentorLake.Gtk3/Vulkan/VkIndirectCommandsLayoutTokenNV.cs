namespace MentorLake.Vulkan;

public class VkIndirectCommandsLayoutTokenNVHandle : BaseSafeHandle
{
}


public static class VkIndirectCommandsLayoutTokenNVExtensions
{

	public static VkIndirectCommandsLayoutTokenNV Dereference(this VkIndirectCommandsLayoutTokenNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndirectCommandsLayoutTokenNV>(x.DangerousGetHandle());
}
internal class VkIndirectCommandsLayoutTokenNVExterns
{
}

public struct VkIndirectCommandsLayoutTokenNV
{
}
