namespace MentorLake.Vulkan;

public class VkPhysicalDeviceVideoEncodeQualityLevelInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVideoEncodeQualityLevelInfoKHRExtensions
{

	public static VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR Dereference(this VkPhysicalDeviceVideoEncodeQualityLevelInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVideoEncodeQualityLevelInfoKHRExterns
{
}

public struct VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR
{
}
