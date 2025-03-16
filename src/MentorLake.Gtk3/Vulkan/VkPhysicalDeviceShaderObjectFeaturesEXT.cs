namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderObjectFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderObjectFeaturesEXTExtensions
{

	public static VkPhysicalDeviceShaderObjectFeaturesEXT Dereference(this VkPhysicalDeviceShaderObjectFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderObjectFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderObjectFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceShaderObjectFeaturesEXT
{
}
