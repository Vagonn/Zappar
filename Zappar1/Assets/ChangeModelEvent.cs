using DynamicBox.EventManagement;

public class ChangeModelEvent : GameEvent
{
	public readonly ModelsChangeType ModelsChangeType;

	public ChangeModelEvent (ModelsChangeType modelsChangeType)
	{
		ModelsChangeType = modelsChangeType;
	}
}