namespace MentorLake.Vulkan;

public class VkDisplayNativeHdrSurfaceCapabilitiesAMDHandle : BaseSafeHandle
{
}


public static class VkDisplayNativeHdrSurfaceCapabilitiesAMDExtensions
{

	public static VkDisplayNativeHdrSurfaceCapabilitiesAMD Dereference(this VkDisplayNativeHdrSurfaceCapabilitiesAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayNativeHdrSurfaceCapabilitiesAMD>(x.DangerousGetHandle());
}
internal class VkDisplayNativeHdrSurfaceCapabilitiesAMDExterns
{
}

public struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
{
}
