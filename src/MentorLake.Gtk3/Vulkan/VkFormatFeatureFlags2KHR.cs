namespace MentorLake.Vulkan;


public class VkFormatFeatureFlags2KHRHandle : BaseSafeHandle
{
}


public static class VkFormatFeatureFlags2KHRExtensions
{

	public static VkFormatFeatureFlags2KHR Dereference(this VkFormatFeatureFlags2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatFeatureFlags2KHR>(x.DangerousGetHandle());
}
internal class VkFormatFeatureFlags2KHRExterns
{
}


public struct VkFormatFeatureFlags2KHR
{
}
