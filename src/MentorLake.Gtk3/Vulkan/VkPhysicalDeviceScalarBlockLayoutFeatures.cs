namespace MentorLake.Vulkan;

public class VkPhysicalDeviceScalarBlockLayoutFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceScalarBlockLayoutFeaturesExtensions
{

	public static VkPhysicalDeviceScalarBlockLayoutFeatures Dereference(this VkPhysicalDeviceScalarBlockLayoutFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceScalarBlockLayoutFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceScalarBlockLayoutFeaturesExterns
{
}

public struct VkPhysicalDeviceScalarBlockLayoutFeatures
{
}
