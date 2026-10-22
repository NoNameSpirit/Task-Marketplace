namespace Blazor_Web_App.Modals;

public class ModalState
{
    public bool IsOpen { get; private set; }
    public Guid TaskId { get; private set; }
    public string TaskTitle { get; private set; } = string.Empty;

    public void Open(Guid taskId, string title = "")
    {
        TaskId = taskId;
        TaskTitle = title;
        IsOpen = true;
    }

    public void Close()
    {
        IsOpen = false;
    }
}