namespace MentorLake.Vulkan;

public class VkExternalMemoryFeatureFlagsHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryFeatureFlagsExtensions
{

	public static VkExternalMemoryFeatureFlags Dereference(this VkExternalMemoryFeatureFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryFeatureFlags>(x.DangerousGetHandle());
}
internal class VkExternalMemoryFeatureFlagsExterns
{
}

public struct VkExternalMemoryFeatureFlags
{
}
