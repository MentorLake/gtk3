namespace MentorLake.Vulkan;

public class VkExternalFenceFeatureFlagsHandle : BaseSafeHandle
{
}


public static class VkExternalFenceFeatureFlagsExtensions
{

	public static VkExternalFenceFeatureFlags Dereference(this VkExternalFenceFeatureFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFenceFeatureFlags>(x.DangerousGetHandle());
}
internal class VkExternalFenceFeatureFlagsExterns
{
}

public struct VkExternalFenceFeatureFlags
{
}
