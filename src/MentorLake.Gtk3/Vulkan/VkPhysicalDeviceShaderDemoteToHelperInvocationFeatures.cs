namespace MentorLake.Vulkan;


public class VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesExtensions
{

	public static VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures Dereference(this VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesExterns
{
}


public struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
{
}
