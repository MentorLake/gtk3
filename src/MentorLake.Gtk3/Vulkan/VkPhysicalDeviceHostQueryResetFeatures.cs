namespace MentorLake.Vulkan;


public class VkPhysicalDeviceHostQueryResetFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceHostQueryResetFeaturesExtensions
{

	public static VkPhysicalDeviceHostQueryResetFeatures Dereference(this VkPhysicalDeviceHostQueryResetFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceHostQueryResetFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceHostQueryResetFeaturesExterns
{
}


public struct VkPhysicalDeviceHostQueryResetFeatures
{
}
