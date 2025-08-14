namespace MentorLake.Vulkan;


public class VkPhysicalDeviceShaderCorePropertiesAMDHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderCorePropertiesAMDExtensions
{

	public static VkPhysicalDeviceShaderCorePropertiesAMD Dereference(this VkPhysicalDeviceShaderCorePropertiesAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderCorePropertiesAMD>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderCorePropertiesAMDExterns
{
}


public struct VkPhysicalDeviceShaderCorePropertiesAMD
{
}
