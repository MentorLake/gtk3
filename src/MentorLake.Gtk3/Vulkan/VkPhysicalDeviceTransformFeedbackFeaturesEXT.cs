namespace MentorLake.Vulkan;

public class VkPhysicalDeviceTransformFeedbackFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTransformFeedbackFeaturesEXTExtensions
{

	public static VkPhysicalDeviceTransformFeedbackFeaturesEXT Dereference(this VkPhysicalDeviceTransformFeedbackFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTransformFeedbackFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTransformFeedbackFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
{
}
