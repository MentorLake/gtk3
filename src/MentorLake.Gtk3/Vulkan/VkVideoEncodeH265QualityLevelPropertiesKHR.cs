namespace MentorLake.Vulkan;


public class VkVideoEncodeH265QualityLevelPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH265QualityLevelPropertiesKHRExtensions
{

	public static VkVideoEncodeH265QualityLevelPropertiesKHR Dereference(this VkVideoEncodeH265QualityLevelPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH265QualityLevelPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH265QualityLevelPropertiesKHRExterns
{
}


public struct VkVideoEncodeH265QualityLevelPropertiesKHR
{
}
