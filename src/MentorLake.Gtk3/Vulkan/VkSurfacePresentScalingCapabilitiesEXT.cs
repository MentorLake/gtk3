namespace MentorLake.Vulkan;

public class VkSurfacePresentScalingCapabilitiesEXTHandle : BaseSafeHandle
{
}


public static class VkSurfacePresentScalingCapabilitiesEXTExtensions
{

	public static VkSurfacePresentScalingCapabilitiesEXT Dereference(this VkSurfacePresentScalingCapabilitiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfacePresentScalingCapabilitiesEXT>(x.DangerousGetHandle());
}
internal class VkSurfacePresentScalingCapabilitiesEXTExterns
{
}

public struct VkSurfacePresentScalingCapabilitiesEXT
{
}
