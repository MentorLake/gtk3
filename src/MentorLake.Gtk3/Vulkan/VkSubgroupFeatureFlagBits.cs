namespace MentorLake.Vulkan;


public class VkSubgroupFeatureFlagBitsHandle : BaseSafeHandle
{
}


public static class VkSubgroupFeatureFlagBitsExtensions
{

	public static VkSubgroupFeatureFlagBits Dereference(this VkSubgroupFeatureFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubgroupFeatureFlagBits>(x.DangerousGetHandle());
}
internal class VkSubgroupFeatureFlagBitsExterns
{
}


public struct VkSubgroupFeatureFlagBits
{
}
