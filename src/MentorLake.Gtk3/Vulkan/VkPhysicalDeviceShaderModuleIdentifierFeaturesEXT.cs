namespace MentorLake.Vulkan;


public class VkPhysicalDeviceShaderModuleIdentifierFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderModuleIdentifierFeaturesEXTExtensions
{

	public static VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT Dereference(this VkPhysicalDeviceShaderModuleIdentifierFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderModuleIdentifierFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
{
}
