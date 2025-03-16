namespace MentorLake.Vulkan;

public class VkGetLatencyMarkerInfoNVHandle : BaseSafeHandle
{
}


public static class VkGetLatencyMarkerInfoNVExtensions
{

	public static VkGetLatencyMarkerInfoNV Dereference(this VkGetLatencyMarkerInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGetLatencyMarkerInfoNV>(x.DangerousGetHandle());
}
internal class VkGetLatencyMarkerInfoNVExterns
{
}

public struct VkGetLatencyMarkerInfoNV
{
}
