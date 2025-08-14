namespace MentorLake.Vulkan;


public class VkFormatFeatureFlagBits2Handle : BaseSafeHandle
{
}


public static class VkFormatFeatureFlagBits2Extensions
{

	public static VkFormatFeatureFlagBits2 Dereference(this VkFormatFeatureFlagBits2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatFeatureFlagBits2>(x.DangerousGetHandle());
}
internal class VkFormatFeatureFlagBits2Externs
{
}


public struct VkFormatFeatureFlagBits2
{
}
