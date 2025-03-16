namespace MentorLake.Vulkan;

public class VkDisplayPlaneAlphaFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayPlaneAlphaFlagsKHRExtensions
{

	public static VkDisplayPlaneAlphaFlagsKHR Dereference(this VkDisplayPlaneAlphaFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPlaneAlphaFlagsKHR>(x.DangerousGetHandle());
}
internal class VkDisplayPlaneAlphaFlagsKHRExterns
{
}

public struct VkDisplayPlaneAlphaFlagsKHR
{
}
