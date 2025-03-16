namespace MentorLake.Vulkan;

public class VkMicromapUsageEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapUsageEXTExtensions
{

	public static VkMicromapUsageEXT Dereference(this VkMicromapUsageEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapUsageEXT>(x.DangerousGetHandle());
}
internal class VkMicromapUsageEXTExterns
{
}

public struct VkMicromapUsageEXT
{
}
