namespace MentorLake.Vulkan;


public class VkDisplayModeParametersKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayModeParametersKHRExtensions
{

	public static VkDisplayModeParametersKHR Dereference(this VkDisplayModeParametersKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayModeParametersKHR>(x.DangerousGetHandle());
}
internal class VkDisplayModeParametersKHRExterns
{
}


public struct VkDisplayModeParametersKHR
{
}
