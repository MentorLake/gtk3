namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderSMBuiltinsPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderSMBuiltinsPropertiesNVExtensions
{

	public static VkPhysicalDeviceShaderSMBuiltinsPropertiesNV Dereference(this VkPhysicalDeviceShaderSMBuiltinsPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderSMBuiltinsPropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderSMBuiltinsPropertiesNVExterns
{
}

public struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
{
}
