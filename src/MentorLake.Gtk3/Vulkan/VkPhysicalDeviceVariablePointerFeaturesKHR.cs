namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVariablePointerFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVariablePointerFeaturesKHRExtensions
{

	public static VkPhysicalDeviceVariablePointerFeaturesKHR Dereference(this VkPhysicalDeviceVariablePointerFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVariablePointerFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVariablePointerFeaturesKHRExterns
{
}


public struct VkPhysicalDeviceVariablePointerFeaturesKHR
{
}
