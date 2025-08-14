namespace MentorLake.Vulkan;


public class VkLatencySleepModeInfoNVHandle : BaseSafeHandle
{
}


public static class VkLatencySleepModeInfoNVExtensions
{

	public static VkLatencySleepModeInfoNV Dereference(this VkLatencySleepModeInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLatencySleepModeInfoNV>(x.DangerousGetHandle());
}
internal class VkLatencySleepModeInfoNVExterns
{
}


public struct VkLatencySleepModeInfoNV
{
}
