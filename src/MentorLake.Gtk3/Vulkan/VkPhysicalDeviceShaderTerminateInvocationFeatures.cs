namespace MentorLake.Vulkan;


public class VkPhysicalDeviceShaderTerminateInvocationFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceShaderTerminateInvocationFeaturesExtensions
{

	public static VkPhysicalDeviceShaderTerminateInvocationFeatures Dereference(this VkPhysicalDeviceShaderTerminateInvocationFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceShaderTerminateInvocationFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceShaderTerminateInvocationFeaturesExterns
{
}


public struct VkPhysicalDeviceShaderTerminateInvocationFeatures
{
}
