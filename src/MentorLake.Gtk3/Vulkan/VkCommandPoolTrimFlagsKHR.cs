namespace MentorLake.Vulkan;

public class VkCommandPoolTrimFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkCommandPoolTrimFlagsKHRExtensions
{

	public static VkCommandPoolTrimFlagsKHR Dereference(this VkCommandPoolTrimFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandPoolTrimFlagsKHR>(x.DangerousGetHandle());
}
internal class VkCommandPoolTrimFlagsKHRExterns
{
}

public struct VkCommandPoolTrimFlagsKHR
{
}
