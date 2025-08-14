namespace MentorLake.Vulkan;


public class VkPhysicalDeviceLinearColorAttachmentFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLinearColorAttachmentFeaturesNVExtensions
{

	public static VkPhysicalDeviceLinearColorAttachmentFeaturesNV Dereference(this VkPhysicalDeviceLinearColorAttachmentFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLinearColorAttachmentFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLinearColorAttachmentFeaturesNVExterns
{
}


public struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
{
}
