namespace MentorLake.Vulkan;

public class VkGeneratedCommandsInfoNVHandle : BaseSafeHandle
{
}


public static class VkGeneratedCommandsInfoNVExtensions
{

	public static VkGeneratedCommandsInfoNV Dereference(this VkGeneratedCommandsInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeneratedCommandsInfoNV>(x.DangerousGetHandle());
}
internal class VkGeneratedCommandsInfoNVExterns
{
}

public struct VkGeneratedCommandsInfoNV
{
}
