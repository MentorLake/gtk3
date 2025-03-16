namespace MentorLake.Vulkan;

public class VkSetStateFlagsIndirectCommandNVHandle : BaseSafeHandle
{
}


public static class VkSetStateFlagsIndirectCommandNVExtensions
{

	public static VkSetStateFlagsIndirectCommandNV Dereference(this VkSetStateFlagsIndirectCommandNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSetStateFlagsIndirectCommandNV>(x.DangerousGetHandle());
}
internal class VkSetStateFlagsIndirectCommandNVExterns
{
}

public struct VkSetStateFlagsIndirectCommandNV
{
}
