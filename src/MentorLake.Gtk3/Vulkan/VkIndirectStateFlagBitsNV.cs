namespace MentorLake.Vulkan;


public class VkIndirectStateFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkIndirectStateFlagBitsNVExtensions
{

	public static VkIndirectStateFlagBitsNV Dereference(this VkIndirectStateFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndirectStateFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkIndirectStateFlagBitsNVExterns
{
}


public struct VkIndirectStateFlagBitsNV
{
}
