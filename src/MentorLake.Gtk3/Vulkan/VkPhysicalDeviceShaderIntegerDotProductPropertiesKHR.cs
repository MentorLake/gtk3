namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderIntegerDotProductPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderIntegerDotProductPropertiesKHRExtensions
{

	public static VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR Dereference(this VkPhysicalDeviceShaderIntegerDotProductPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderIntegerDotProductPropertiesKHRExterns
{
}

public struct VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR
{
}
