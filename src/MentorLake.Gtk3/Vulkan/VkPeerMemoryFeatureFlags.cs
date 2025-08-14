namespace MentorLake.Vulkan;


public class VkPeerMemoryFeatureFlagsHandle : BaseSafeHandle
{
}


public static class VkPeerMemoryFeatureFlagsExtensions
{

	public static VkPeerMemoryFeatureFlags Dereference(this VkPeerMemoryFeatureFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPeerMemoryFeatureFlags>(x.DangerousGetHandle());
}
internal class VkPeerMemoryFeatureFlagsExterns
{
}


public struct VkPeerMemoryFeatureFlags
{
}
