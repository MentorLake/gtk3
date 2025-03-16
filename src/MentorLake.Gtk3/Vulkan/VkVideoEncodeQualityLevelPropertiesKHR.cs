namespace MentorLake.Vulkan;

public class VkVideoEncodeQualityLevelPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeQualityLevelPropertiesKHRExtensions
{

	public static VkVideoEncodeQualityLevelPropertiesKHR Dereference(this VkVideoEncodeQualityLevelPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeQualityLevelPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeQualityLevelPropertiesKHRExterns
{
}

public struct VkVideoEncodeQualityLevelPropertiesKHR
{
}
