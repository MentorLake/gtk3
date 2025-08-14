namespace MentorLake.Vulkan;


public class VkDeviceDiagnosticsConfigFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkDeviceDiagnosticsConfigFlagBitsNVExtensions
{

	public static VkDeviceDiagnosticsConfigFlagBitsNV Dereference(this VkDeviceDiagnosticsConfigFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceDiagnosticsConfigFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkDeviceDiagnosticsConfigFlagBitsNVExterns
{
}


public struct VkDeviceDiagnosticsConfigFlagBitsNV
{
}
