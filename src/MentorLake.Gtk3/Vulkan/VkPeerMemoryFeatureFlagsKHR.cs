namespace MentorLake.Vulkan;


public class VkPeerMemoryFeatureFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkPeerMemoryFeatureFlagsKHRExtensions
{

	public static VkPeerMemoryFeatureFlagsKHR Dereference(this VkPeerMemoryFeatureFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPeerMemoryFeatureFlagsKHR>(x.DangerousGetHandle());
}
internal class VkPeerMemoryFeatureFlagsKHRExterns
{
}


public struct VkPeerMemoryFeatureFlagsKHR
{
}
