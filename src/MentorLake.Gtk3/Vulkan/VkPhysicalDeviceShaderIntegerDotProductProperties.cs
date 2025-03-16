namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderIntegerDotProductPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderIntegerDotProductPropertiesExtensions
{

	public static VkPhysicalDeviceShaderIntegerDotProductProperties Dereference(this VkPhysicalDeviceShaderIntegerDotProductPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderIntegerDotProductProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderIntegerDotProductPropertiesExterns
{
}

public struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
}
