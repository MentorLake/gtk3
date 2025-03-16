namespace MentorLake.Vulkan;

public class VkPhysicalDeviceHostQueryResetFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceHostQueryResetFeaturesEXTExtensions
{

	public static VkPhysicalDeviceHostQueryResetFeaturesEXT Dereference(this VkPhysicalDeviceHostQueryResetFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceHostQueryResetFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceHostQueryResetFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceHostQueryResetFeaturesEXT
{
}
