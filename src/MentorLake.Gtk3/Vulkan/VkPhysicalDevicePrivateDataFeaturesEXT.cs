namespace MentorLake.Vulkan;


public class VkPhysicalDevicePrivateDataFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePrivateDataFeaturesEXTExtensions
{

	public static VkPhysicalDevicePrivateDataFeaturesEXT Dereference(this VkPhysicalDevicePrivateDataFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePrivateDataFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePrivateDataFeaturesEXTExterns
{
}


public struct VkPhysicalDevicePrivateDataFeaturesEXT
{
}
