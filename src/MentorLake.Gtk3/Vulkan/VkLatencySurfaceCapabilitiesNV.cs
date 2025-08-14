namespace MentorLake.Vulkan;


public class VkLatencySurfaceCapabilitiesNVHandle : BaseSafeHandle
{
}


public static class VkLatencySurfaceCapabilitiesNVExtensions
{

	public static VkLatencySurfaceCapabilitiesNV Dereference(this VkLatencySurfaceCapabilitiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLatencySurfaceCapabilitiesNV>(x.DangerousGetHandle());
}
internal class VkLatencySurfaceCapabilitiesNVExterns
{
}


public struct VkLatencySurfaceCapabilitiesNV
{
}
