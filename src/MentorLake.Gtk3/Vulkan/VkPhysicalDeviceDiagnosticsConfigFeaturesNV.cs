namespace MentorLake.Vulkan;

public class VkPhysicalDeviceDiagnosticsConfigFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDiagnosticsConfigFeaturesNVExtensions
{

	public static VkPhysicalDeviceDiagnosticsConfigFeaturesNV Dereference(this VkPhysicalDeviceDiagnosticsConfigFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDiagnosticsConfigFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDiagnosticsConfigFeaturesNVExterns
{
}

public struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
{
}
