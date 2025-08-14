namespace MentorLake.Vulkan;


public class VkIndirectCommandsLayoutUsageFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkIndirectCommandsLayoutUsageFlagBitsNVExtensions
{

	public static VkIndirectCommandsLayoutUsageFlagBitsNV Dereference(this VkIndirectCommandsLayoutUsageFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndirectCommandsLayoutUsageFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkIndirectCommandsLayoutUsageFlagBitsNVExterns
{
}


public struct VkIndirectCommandsLayoutUsageFlagBitsNV
{
}
