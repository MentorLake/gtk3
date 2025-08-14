namespace MentorLake.Vulkan;


public class VkFormatFeatureFlags2Handle : BaseSafeHandle
{
}


public static class VkFormatFeatureFlags2Extensions
{

	public static VkFormatFeatureFlags2 Dereference(this VkFormatFeatureFlags2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatFeatureFlags2>(x.DangerousGetHandle());
}
internal class VkFormatFeatureFlags2Externs
{
}


public struct VkFormatFeatureFlags2
{
}
