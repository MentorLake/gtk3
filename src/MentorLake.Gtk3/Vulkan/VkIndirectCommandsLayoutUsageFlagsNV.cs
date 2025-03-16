namespace MentorLake.Vulkan;

public class VkIndirectCommandsLayoutUsageFlagsNVHandle : BaseSafeHandle
{
}


public static class VkIndirectCommandsLayoutUsageFlagsNVExtensions
{

	public static VkIndirectCommandsLayoutUsageFlagsNV Dereference(this VkIndirectCommandsLayoutUsageFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndirectCommandsLayoutUsageFlagsNV>(x.DangerousGetHandle());
}
internal class VkIndirectCommandsLayoutUsageFlagsNVExterns
{
}

public struct VkIndirectCommandsLayoutUsageFlagsNV
{
}
