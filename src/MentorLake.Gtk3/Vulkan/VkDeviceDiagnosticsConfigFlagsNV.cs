namespace MentorLake.Vulkan;

public class VkDeviceDiagnosticsConfigFlagsNVHandle : BaseSafeHandle
{
}


public static class VkDeviceDiagnosticsConfigFlagsNVExtensions
{

	public static VkDeviceDiagnosticsConfigFlagsNV Dereference(this VkDeviceDiagnosticsConfigFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceDiagnosticsConfigFlagsNV>(x.DangerousGetHandle());
}
internal class VkDeviceDiagnosticsConfigFlagsNVExterns
{
}

public struct VkDeviceDiagnosticsConfigFlagsNV
{
}
