namespace MentorLake.Vulkan;


public class VkPeerMemoryFeatureFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkPeerMemoryFeatureFlagBitsKHRExtensions
{

	public static VkPeerMemoryFeatureFlagBitsKHR Dereference(this VkPeerMemoryFeatureFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPeerMemoryFeatureFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkPeerMemoryFeatureFlagBitsKHRExterns
{
}


public struct VkPeerMemoryFeatureFlagBitsKHR
{
}
