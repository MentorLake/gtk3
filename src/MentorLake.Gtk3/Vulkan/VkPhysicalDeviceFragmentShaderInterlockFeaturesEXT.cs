namespace MentorLake.Vulkan;


public class VkPhysicalDeviceFragmentShaderInterlockFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFragmentShaderInterlockFeaturesEXTExtensions
{

	public static VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT Dereference(this VkPhysicalDeviceFragmentShaderInterlockFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFragmentShaderInterlockFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
{
}
