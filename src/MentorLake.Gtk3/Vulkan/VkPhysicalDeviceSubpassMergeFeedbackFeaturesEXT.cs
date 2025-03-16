namespace MentorLake.Vulkan;

public class VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXTExtensions
{

	public static VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT Dereference(this VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
{
}
