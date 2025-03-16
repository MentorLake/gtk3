namespace MentorLake.Vulkan;

public class VkPhysicalDeviceVariablePointerFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVariablePointerFeaturesExtensions
{

	public static VkPhysicalDeviceVariablePointerFeatures Dereference(this VkPhysicalDeviceVariablePointerFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVariablePointerFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVariablePointerFeaturesExterns
{
}

public struct VkPhysicalDeviceVariablePointerFeatures
{
}
