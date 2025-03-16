namespace MentorLake.Vulkan;

public class VkLatencySleepInfoNVHandle : BaseSafeHandle
{
}


public static class VkLatencySleepInfoNVExtensions
{

	public static VkLatencySleepInfoNV Dereference(this VkLatencySleepInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLatencySleepInfoNV>(x.DangerousGetHandle());
}
internal class VkLatencySleepInfoNVExterns
{
}

public struct VkLatencySleepInfoNV
{
}
