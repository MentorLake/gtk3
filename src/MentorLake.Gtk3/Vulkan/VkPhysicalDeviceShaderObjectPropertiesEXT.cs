namespace MentorLake.Vulkan;


public class VkPhysicalDeviceShaderObjectPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderObjectPropertiesEXTExtensions
{

	public static VkPhysicalDeviceShaderObjectPropertiesEXT Dereference(this VkPhysicalDeviceShaderObjectPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderObjectPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderObjectPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceShaderObjectPropertiesEXT
{
}
