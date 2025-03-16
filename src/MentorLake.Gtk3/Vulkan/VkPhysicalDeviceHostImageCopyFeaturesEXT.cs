namespace MentorLake.Vulkan;

public class VkPhysicalDeviceHostImageCopyFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceHostImageCopyFeaturesEXTExtensions
{

	public static VkPhysicalDeviceHostImageCopyFeaturesEXT Dereference(this VkPhysicalDeviceHostImageCopyFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceHostImageCopyFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceHostImageCopyFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceHostImageCopyFeaturesEXT
{
}
