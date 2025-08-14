namespace MentorLake.Vulkan;


public class VkLatencyMarkerNVHandle : BaseSafeHandle
{
}


public static class VkLatencyMarkerNVExtensions
{

	public static VkLatencyMarkerNV Dereference(this VkLatencyMarkerNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLatencyMarkerNV>(x.DangerousGetHandle());
}
internal class VkLatencyMarkerNVExterns
{
}


public struct VkLatencyMarkerNV
{
}
