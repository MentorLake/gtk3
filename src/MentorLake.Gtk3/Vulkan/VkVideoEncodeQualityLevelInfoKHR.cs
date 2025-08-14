namespace MentorLake.Vulkan;


public class VkVideoEncodeQualityLevelInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoEncodeQualityLevelInfoKHRExtensions
{

	public static VkVideoEncodeQualityLevelInfoKHR Dereference(this VkVideoEncodeQualityLevelInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoEncodeQualityLevelInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoEncodeQualityLevelInfoKHRExterns
{
}


public struct VkVideoEncodeQualityLevelInfoKHR
{
}
