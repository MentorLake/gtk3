namespace MentorLake.Vulkan;


public class VkPeerMemoryFeatureFlagBitsHandle : BaseSafeHandle
{
}


public static class VkPeerMemoryFeatureFlagBitsExtensions
{

	public static VkPeerMemoryFeatureFlagBits Dereference(this VkPeerMemoryFeatureFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPeerMemoryFeatureFlagBits>(x.DangerousGetHandle());
}
internal class VkPeerMemoryFeatureFlagBitsExterns
{
}


public struct VkPeerMemoryFeatureFlagBits
{
}
