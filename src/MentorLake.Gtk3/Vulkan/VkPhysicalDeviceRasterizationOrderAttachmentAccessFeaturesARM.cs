namespace MentorLake.Vulkan;

public class VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARMExtensions
{

	public static VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM Dereference(this VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARMExterns
{
}

public struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
{
}
