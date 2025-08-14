namespace MentorLake.Vulkan;


public class VkPhysicalDeviceScalarBlockLayoutFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceScalarBlockLayoutFeaturesEXTExtensions
{

	public static VkPhysicalDeviceScalarBlockLayoutFeaturesEXT Dereference(this VkPhysicalDeviceScalarBlockLayoutFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceScalarBlockLayoutFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceScalarBlockLayoutFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT
{
}
