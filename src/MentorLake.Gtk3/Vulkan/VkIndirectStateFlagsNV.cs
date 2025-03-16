namespace MentorLake.Vulkan;

public class VkIndirectStateFlagsNVHandle : BaseSafeHandle
{
}


public static class VkIndirectStateFlagsNVExtensions
{

	public static VkIndirectStateFlagsNV Dereference(this VkIndirectStateFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndirectStateFlagsNV>(x.DangerousGetHandle());
}
internal class VkIndirectStateFlagsNVExterns
{
}

public struct VkIndirectStateFlagsNV
{
}
