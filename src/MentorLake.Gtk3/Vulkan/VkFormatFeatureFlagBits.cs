namespace MentorLake.Vulkan;


public class VkFormatFeatureFlagBitsHandle : BaseSafeHandle
{
}


public static class VkFormatFeatureFlagBitsExtensions
{

	public static VkFormatFeatureFlagBits Dereference(this VkFormatFeatureFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatFeatureFlagBits>(x.DangerousGetHandle());
}
internal class VkFormatFeatureFlagBitsExterns
{
}


public struct VkFormatFeatureFlagBits
{
}
