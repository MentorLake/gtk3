namespace MentorLake.Vulkan;

public class VkCuLaunchInfoNVXHandle : BaseSafeHandle
{
}


public static class VkCuLaunchInfoNVXExtensions
{

	public static VkCuLaunchInfoNVX Dereference(this VkCuLaunchInfoNVXHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCuLaunchInfoNVX>(x.DangerousGetHandle());
}
internal class VkCuLaunchInfoNVXExterns
{
}

public struct VkCuLaunchInfoNVX
{
}
