namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderModuleIdentifierPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderModuleIdentifierPropertiesEXTExtensions
{

	public static VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT Dereference(this VkPhysicalDeviceShaderModuleIdentifierPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderModuleIdentifierPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
{
}
