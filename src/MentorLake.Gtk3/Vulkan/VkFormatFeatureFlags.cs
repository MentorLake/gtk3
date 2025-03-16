namespace MentorLake.Vulkan;

public class VkFormatFeatureFlagsHandle : BaseSafeHandle
{
}


public static class VkFormatFeatureFlagsExtensions
{

	public static VkFormatFeatureFlags Dereference(this VkFormatFeatureFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatFeatureFlags>(x.DangerousGetHandle());
}
internal class VkFormatFeatureFlagsExterns
{
}

public struct VkFormatFeatureFlags
{
}
