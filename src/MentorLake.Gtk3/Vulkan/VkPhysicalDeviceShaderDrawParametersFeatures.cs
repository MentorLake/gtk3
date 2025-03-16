namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderDrawParametersFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderDrawParametersFeaturesExtensions
{

	public static VkPhysicalDeviceShaderDrawParametersFeatures Dereference(this VkPhysicalDeviceShaderDrawParametersFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderDrawParametersFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderDrawParametersFeaturesExterns
{
}

public struct VkPhysicalDeviceShaderDrawParametersFeatures
{
}
