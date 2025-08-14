namespace MentorLake.Vulkan;


public class VkVideoEncodeH264QualityLevelPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeH264QualityLevelPropertiesKHRExtensions
{

	public static VkVideoEncodeH264QualityLevelPropertiesKHR Dereference(this VkVideoEncodeH264QualityLevelPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeH264QualityLevelPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeH264QualityLevelPropertiesKHRExterns
{
}


public struct VkVideoEncodeH264QualityLevelPropertiesKHR
{
}
