namespace MentorLake.Vulkan;


public class VkPhysicalDevicePrivateDataFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePrivateDataFeaturesExtensions
{

	public static VkPhysicalDevicePrivateDataFeatures Dereference(this VkPhysicalDevicePrivateDataFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePrivateDataFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePrivateDataFeaturesExterns
{
}


public struct VkPhysicalDevicePrivateDataFeatures
{
}
