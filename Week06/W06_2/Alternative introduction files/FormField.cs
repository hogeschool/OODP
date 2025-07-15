public class FormField<T>
{
    public string Name { get; }
    public T Value { get; set; }

    public FormField(string name) => Name = name;

    public void ResetValue()
    {
        //We can't say Value = 0, Value = "", etc.
        //because we don't know the type until runtime.
        Value = default;
    }
}