namespace MentorLake.Vulkan;

public class VkDisplayModeCreateFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayModeCreateFlagsKHRExtensions
{

	public static VkDisplayModeCreateFlagsKHR Dereference(this VkDisplayModeCreateFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayModeCreateFlagsKHR>(x.DangerousGetHandle());
}
internal class VkDisplayModeCreateFlagsKHRExterns
{
}

public struct VkDisplayModeCreateFlagsKHR
{
}
