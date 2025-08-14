namespace MentorLake.Vulkan;


public class VkExternalSemaphoreFeatureFlagsHandle : BaseSafeHandle
{
}


public static class VkExternalSemaphoreFeatureFlagsExtensions
{

	public static VkExternalSemaphoreFeatureFlags Dereference(this VkExternalSemaphoreFeatureFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalSemaphoreFeatureFlags>(x.DangerousGetHandle());
}
internal class VkExternalSemaphoreFeatureFlagsExterns
{
}


public struct VkExternalSemaphoreFeatureFlags
{
}
