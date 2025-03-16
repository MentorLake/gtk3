namespace MentorLake.Vulkan;

public class VkPhysicalDeviceShaderAtomicFloatFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderAtomicFloatFeaturesEXTExtensions
{

	public static VkPhysicalDeviceShaderAtomicFloatFeaturesEXT Dereference(this VkPhysicalDeviceShaderAtomicFloatFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderAtomicFloatFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderAtomicFloatFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
{
}
