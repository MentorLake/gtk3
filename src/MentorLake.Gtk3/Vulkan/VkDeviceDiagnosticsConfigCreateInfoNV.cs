namespace MentorLake.Vulkan;


public class VkDeviceDiagnosticsConfigCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkDeviceDiagnosticsConfigCreateInfoNVExtensions
{

	public static VkDeviceDiagnosticsConfigCreateInfoNV Dereference(this VkDeviceDiagnosticsConfigCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceDiagnosticsConfigCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkDeviceDiagnosticsConfigCreateInfoNVExterns
{
}


public struct VkDeviceDiagnosticsConfigCreateInfoNV
{
}
