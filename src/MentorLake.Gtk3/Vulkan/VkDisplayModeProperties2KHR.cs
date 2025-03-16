namespace MentorLake.Vulkan;

public class VkDisplayModeProperties2KHRHandle : BaseSafeHandle
{
}


public static class VkDisplayModeProperties2KHRExtensions
{

	public static VkDisplayModeProperties2KHR Dereference(this VkDisplayModeProperties2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayModeProperties2KHR>(x.DangerousGetHandle());
}
internal class VkDisplayModeProperties2KHRExterns
{
}

public struct VkDisplayModeProperties2KHR
{
}
