namespace MentorLake.Vulkan;


public class VkFormatFeatureFlagBits2KHRHandle : BaseSafeHandle
{
}


public static class VkFormatFeatureFlagBits2KHRExtensions
{

	public static VkFormatFeatureFlagBits2KHR Dereference(this VkFormatFeatureFlagBits2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatFeatureFlagBits2KHR>(x.DangerousGetHandle());
}
internal class VkFormatFeatureFlagBits2KHRExterns
{
}


public struct VkFormatFeatureFlagBits2KHR
{
}
