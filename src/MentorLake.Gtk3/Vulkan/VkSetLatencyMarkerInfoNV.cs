namespace MentorLake.Vulkan;


public class VkSetLatencyMarkerInfoNVHandle : BaseSafeHandle
{
}


public static class VkSetLatencyMarkerInfoNVExtensions
{

	public static VkSetLatencyMarkerInfoNV Dereference(this VkSetLatencyMarkerInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSetLatencyMarkerInfoNV>(x.DangerousGetHandle());
}
internal class VkSetLatencyMarkerInfoNVExterns
{
}


public struct VkSetLatencyMarkerInfoNV
{
}
