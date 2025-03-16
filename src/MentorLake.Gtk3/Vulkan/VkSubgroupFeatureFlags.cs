namespace MentorLake.Vulkan;

public class VkSubgroupFeatureFlagsHandle : BaseSafeHandle
{
}


public static class VkSubgroupFeatureFlagsExtensions
{

	public static VkSubgroupFeatureFlags Dereference(this VkSubgroupFeatureFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubgroupFeatureFlags>(x.DangerousGetHandle());
}
internal class VkSubgroupFeatureFlagsExterns
{
}

public struct VkSubgroupFeatureFlags
{
}
