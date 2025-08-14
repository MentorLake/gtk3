namespace MentorLake.Vulkan;


public class VkPhysicalDeviceImageProcessingFeaturesQCOMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageProcessingFeaturesQCOMExtensions
{

	public static VkPhysicalDeviceImageProcessingFeaturesQCOM Dereference(this VkPhysicalDeviceImageProcessingFeaturesQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageProcessingFeaturesQCOM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageProcessingFeaturesQCOMExterns
{
}


public struct VkPhysicalDeviceImageProcessingFeaturesQCOM
{
}
