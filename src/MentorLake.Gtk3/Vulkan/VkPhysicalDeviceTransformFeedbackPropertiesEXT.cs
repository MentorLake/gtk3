namespace MentorLake.Vulkan;

public class VkPhysicalDeviceTransformFeedbackPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTransformFeedbackPropertiesEXTExtensions
{

	public static VkPhysicalDeviceTransformFeedbackPropertiesEXT Dereference(this VkPhysicalDeviceTransformFeedbackPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTransformFeedbackPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTransformFeedbackPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
}
